using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouLoad
{
    public partial class Form1 : Form
    {
        private string ytDlpPath;
        private string ffmpegPath;
        private string outputFolder;
        private bool isPlaylistCurrent;
        private string currentPlaylistTitle;
        private Process currentDownloadProcess;
        private CancellationTokenSource downloadCts;

        private readonly ImageList thumbnailImageList = new ImageList
        {
            ImageSize = new Size(80, 45),
            ColorDepth = ColorDepth.Depth32Bit
        };

        private readonly string logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "YouLoad_Downloads.log");

        public Form1()
        {
            InitializeComponent();
            InitializeCustom();
        }

        private void InitializeCustom()
        {
            ytDlpPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "yt-dlp.exe");
            ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");

            // ListView Setup
            lvMedia.Columns.Clear();
            lvMedia.Columns.Add("Vorschau", 90);
            lvMedia.Columns.Add("Titel", 280);
            lvMedia.Columns.Add("Kanal", 180);
            lvMedia.Columns.Add("Dauer", 70);
            lvMedia.Columns.Add("URL", 0);

            lvMedia.FullRowSelect = true;
            lvMedia.View = View.Details;
            lvMedia.SmallImageList = thumbnailImageList;

            pbStatus.Style = ProgressBarStyle.Blocks;
            pbStatus.Value = 0;

            btnDownload.Enabled = false;
            btnCancel.Enabled = false;
            btnReset.Enabled = true;

            cbRework.Items.AddRange(new[] { "do nothing", "notify", "exit program", "lock computer", "log out user", "shut down" });
            cbRework.SelectedIndex = 0;

            // 🔥 TEMPLATE BUILDER EVENTS
            btnIndex.Click += (s, e) => InsertTemplate("%(playlist_index)02d");
            btnTitle.Click += (s, e) => InsertTemplate("%(title)s");
            btnChannel.Click += (s, e) => InsertTemplate("%(uploader)s");
            btnDate.Click += (s, e) => InsertTemplate("%(upload_date)s");
            btnDuration.Click += (s, e) => InsertTemplate("%(duration)s");
            btnID.Click += (s, e) => InsertTemplate("%(id)s");
            btnUnderline.Click += (s, e) => InsertTemplate("_");
            btnMinus.Click += (s, e) => InsertTemplate("-");
            btnResetName.Click += (s, e) => tbFileName.Text = "%(uploader)s - %(title)s.%(ext)s";

            // Default Template
            tbFileName.Text = "%(uploader)s - %(title)s.%(ext)s";

            // Events
            Shown += async (s, e) => await InitializeToolsAsync();

            tbURL.TextChanged += (s, e) => btnDownload.Enabled = !string.IsNullOrWhiteSpace(tbURL.Text);

            btnUrlLoad.Click += async (s, e) => await LoadMediaFromUrl();
            tbURL.KeyDown += async (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    await LoadMediaFromUrl();
                }
            };

            rbVideo.CheckedChanged += RadioFormatChanged;
            rbAudio.CheckedChanged += RadioFormatChanged;

            btnOutput.Click += BtnOutput_Click;
            btnOpenOutput.Click += BtnOpenOutput_Click;
            btnPaste.Click += BtnPaste_Click;
            btnDownload.Click += async (s, e) => await StartDownload();
            btnCancel.Click += BtnCancel_Click;
            btnReset.Click += BtnReset_Click;
        }

        // 🔥 TEMPLATE BUILDER FUNKTION
        private void InsertTemplate(string template)
        {
            int cursorPos = tbFileName.SelectionStart;
            tbFileName.Text = tbFileName.Text.Insert(cursorPos, template);
            tbFileName.SelectionStart = cursorPos + template.Length;
            tbFileName.SelectionLength = 0;
            tbFileName.Focus();
            LogDownload($"Template hinzugefügt: {template} → '{tbFileName.Text}'");
        }

        private bool isDarkMode = false;

        private void ToggleDarkMode()
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                this.BackColor = Color.FromArgb(32, 32, 32);
                this.ForeColor = Color.White;

                foreach (Control c in this.Controls)
                {
                    if (c is Label || c is Button || c is CheckBox || c is RadioButton || c is GroupBox || c is ComboBox || c is TextBox)
                    {
                        c.BackColor = Color.FromArgb(45, 45, 45);
                        c.ForeColor = Color.White;
                    }
                }
                lvMedia.BackColor = Color.FromArgb(45, 45, 45);
                lvMedia.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = SystemColors.Window;
                this.ForeColor = SystemColors.WindowText;

                foreach (Control c in this.Controls)
                {
                    if (c is Label || c is Button || c is CheckBox || c is RadioButton || c is GroupBox || c is ComboBox || c is TextBox)
                    {
                        c.BackColor = SystemColors.Window;
                        c.ForeColor = SystemColors.WindowText;
                    }
                }
                lvMedia.BackColor = SystemColors.Window;
                lvMedia.ForeColor = SystemColors.WindowText;
            }
        }

        #region Tool Initialization
        private async Task InitializeToolsAsync()
        {
            LockUi(true, "Initialisiere yt-dlp und FFmpeg...");
            try
            {
                await EnsureYtDlpExistsAndUpdated();
                await EnsureFfmpegExists();
                SetStatus("Bereit");
            }
            catch (Exception ex)
            {
                SetStatus("Fehler bei Initialisierung: " + ex.Message, true);
            }
            finally
            {
                LockUi(false);
            }
        }

        private async Task EnsureFfmpegExists()
        {
            if (File.Exists(ffmpegPath)) return;

            SetStatus("FFmpeg wird heruntergeladen...");
            string zipPath = Path.Combine(Path.GetTempPath(), "ffmpeg.zip");
            string url = "https://github.com/BtbN/FFmpeg-Builds/releases/download/latest/ffmpeg-master-latest-win64-gpl.zip";

            using (WebClient wc = new WebClient())
                await wc.DownloadFileTaskAsync(new Uri(url), zipPath);

            ZipArchive archive = null;
            try
            {
                archive = ZipFile.OpenRead(zipPath);
                var entry = archive.Entries.FirstOrDefault(e => e.FullName.EndsWith("ffmpeg.exe", StringComparison.OrdinalIgnoreCase));
                if (entry != null)
                    entry.ExtractToFile(ffmpegPath, true);
            }
            finally
            {
                archive?.Dispose();
            }

            if (File.Exists(zipPath)) File.Delete(zipPath);
            SetStatus("FFmpeg wurde installiert.");
        }

        private async Task EnsureYtDlpExistsAndUpdated()
        {
            if (!File.Exists(ytDlpPath))
            {
                SetStatus("yt-dlp wird heruntergeladen...");
                await DownloadYtDlpBinary();
            }
            SetStatus("Prüfe auf yt-dlp Updates...");
            bool updated = await RunYtDlpUpdate();
            SetStatus(updated ? "yt-dlp aktualisiert." : "yt-dlp ist aktuell.");
        }

        private async Task DownloadYtDlpBinary()
        {
            string url = "https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp.exe";
            using (WebClient wc = new WebClient())
                await wc.DownloadFileTaskAsync(new Uri(url), ytDlpPath);
        }

        private async Task<bool> RunYtDlpUpdate()
        {
            var psi = new ProcessStartInfo
            {
                FileName = ytDlpPath,
                Arguments = "-U",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true
            };

            using (Process proc = new Process { StartInfo = psi })
            {
                var tcs = new TaskCompletionSource<bool>();
                bool updated = false;

                proc.EnableRaisingEvents = true;
                proc.Exited += (s, e) =>
                {
                    try
                    {
                        if (new FileInfo(ytDlpPath).LastWriteTime >= DateTime.Now.AddMinutes(-5))
                            updated = true;
                    }
                    catch { }
                    tcs.TrySetResult(updated);
                };

                proc.Start();
                await Task.Run(() => proc.WaitForExit());
                return updated;
            }
        }
        #endregion

        private void RadioFormatChanged(object sender, EventArgs e)
        {
            cbFormat.Items.Clear();
            if (rbAudio.Checked)
                cbFormat.Items.AddRange(new[] { "MP3", "AAC", "WebM", "FLAC", "OGG", "WAV", "M4A", "Opus" });
            else
                cbFormat.Items.AddRange(new[] { "MP4", "MKV", "WebM", "AVI", "MOV", "FLV" });

            if (cbFormat.Items.Count > 0) cbFormat.SelectedIndex = 0;
        }

        #region UI Helpers
        private void LockUi(bool locked, string statusText = null)
        {
            foreach (Control c in Controls)
            {
                if (object.ReferenceEquals(c, lblStatus) || object.ReferenceEquals(c, pbStatus)) continue;
                c.Enabled = !locked;
            }

            if (!string.IsNullOrEmpty(statusText))
                lblStatus.Text = statusText;

            if (locked)
            {
                pbStatus.Style = ProgressBarStyle.Marquee;
                btnCancel.Enabled = true;
                btnReset.Enabled = false;
            }
            else
            {
                pbStatus.Style = ProgressBarStyle.Blocks;
                pbStatus.Value = 0;
                btnCancel.Enabled = false;
                btnReset.Enabled = true;
            }
        }

        private void SetStatus(string text, bool isError = false)
        {
            lblStatus.Text = text;
            lblStatus.ForeColor = isError ? Color.Red : Color.Black;
        }

        private void LogDownload(string message)
        {
            try
            {
                File.AppendAllText(logFilePath, $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}{Environment.NewLine}");
            }
            catch { }
        }
        #endregion

        #region Button Events
        private void BtnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText()) tbURL.Text = Clipboard.GetText();
        }

        private void BtnOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    outputFolder = fbd.SelectedPath;
                    SetStatus("Zielordner: " + outputFolder);
                }
            }
        }

        private void BtnOpenOutput_Click(object sender, EventArgs e)
        {
            string folder = outputFolder ?? GetDefaultDownloadFolder();
            if (Directory.Exists(folder))
                Process.Start("explorer.exe", folder);
            else
                SetStatus("Ordner nicht gefunden.", true);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            downloadCts?.Cancel();
            try { currentDownloadProcess?.Kill(); } catch { }
            SetStatus("Download abgebrochen.");
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            tbURL.Clear();
            lvMedia.Items.Clear();
            thumbnailImageList.Images.Clear();
            isPlaylistCurrent = false;
            currentPlaylistTitle = null;
            SetStatus("Zurückgesetzt.");
            btnDownload.Enabled = false;
        }
        #endregion

        #region Helper Methods
        private string GetDefaultDownloadFolder()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }

        private string MakeSafeFilename(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
                name = name.Replace(c, '_');
            return name.Trim();
        }

        private string GetString(JsonElement el, string key)
        {
            return el.TryGetProperty(key, out JsonElement p) && p.ValueKind == JsonValueKind.String ? p.GetString() : "";
        }

        private string GetDurationStringFromJson(JsonElement el)
        {
            if (el.TryGetProperty("duration", out JsonElement p) && p.ValueKind == JsonValueKind.Number)
                return TimeSpan.FromSeconds(p.GetDouble()).ToString(@"hh\:mm\:ss");
            return "";
        }
        #endregion

        #region Metadaten laden
        private async Task LoadMediaFromUrl()
        {
            string url = tbURL.Text.Trim();
            if (string.IsNullOrEmpty(url))
            {
                SetStatus("Bitte URL eingeben.", true);
                return;
            }

            LockUi(true, "Lade Metadaten...");
            lvMedia.Items.Clear();
            thumbnailImageList.Images.Clear();

            try
            {
                SetStatus("Starte yt-dlp...");
                string json = await RunYtDlpAndGetJson(url);
                LogDownload($"yt-dlp JSON Response (Länge: {json?.Length ?? 0}): {json?.Substring(0, Math.Min(500, json.Length)) ?? "NULL"}");

                if (string.IsNullOrEmpty(json))
                {
                    SetStatus("❌ yt-dlp hat keine Daten zurückgegeben.", true);
                    return;
                }

                using (JsonDocument doc = JsonDocument.Parse(json))
                {
                    JsonElement root = doc.RootElement;
                    LogDownload($"JSON Root Keys: {string.Join(", ", root.EnumerateObject().Select(p => p.Name))}");

                    if (root.TryGetProperty("entries", out JsonElement entries) && entries.ValueKind == JsonValueKind.Array)
                    {
                        isPlaylistCurrent = true;
                        currentPlaylistTitle = GetString(root, "title");
                        LogDownload($"Playlist gefunden: {currentPlaylistTitle} ({entries.GetArrayLength()} Einträge)");

                        foreach (var entry in entries.EnumerateArray())
                        {
                            await AddMediaItemToListView(entry);
                        }
                        SetStatus($"✅ Playlist geladen: {currentPlaylistTitle} ({lvMedia.Items.Count} Einträge)");
                    }
                    else
                    {
                        LogDownload("Einzelvideo erkannt");
                        await AddMediaItemToListView(root);
                        isPlaylistCurrent = false;
                        SetStatus("✅ Einzelvideo geladen.");
                    }
                }
                btnDownload.Enabled = lvMedia.Items.Count > 0;
            }
            catch (Exception ex)
            {
                string errorMsg = $"❌ Fehler beim Laden: {ex.Message}";
                SetStatus(errorMsg, true);
                LogDownload(errorMsg + " | Stack: " + ex.StackTrace);
            }
            finally
            {
                LockUi(false, "Bereit");
            }
        }

        private async Task AddMediaItemToListView(JsonElement entry)
        {
            string title = GetString(entry, "title");
            string channel = GetString(entry, "channel") ?? GetString(entry, "uploader");
            string duration = GetDurationStringFromJson(entry);
            string webpageUrl = GetString(entry, "webpage_url") ?? GetString(entry, "url") ?? tbURL.Text;
            string thumbUrl = GetString(entry, "thumbnail");

            LogDownload($"Verarbeite: {title} | Channel: {channel} | Thumb: {thumbUrl}");

            int imgIndex = -1;
            if (!string.IsNullOrEmpty(thumbUrl))
            {
                try
                {
                    using (WebClient wc = new WebClient())
                    {
                        wc.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
                        byte[] data = await wc.DownloadDataTaskAsync(thumbUrl);
                        LogDownload($"Thumbnail geladen: {thumbUrl} ({data.Length} bytes)");

                        using (MemoryStream ms = new MemoryStream(data))
                        {
                            Image thumb = Image.FromStream(ms);
                            Image scaledThumb = new Bitmap(thumb, thumbnailImageList.ImageSize);
                            imgIndex = thumbnailImageList.Images.Count;
                            thumbnailImageList.Images.Add(scaledThumb);
                            thumb.Dispose();
                            scaledThumb.Dispose();
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogDownload($"Thumbnail Fehler für {thumbUrl}: {ex.Message}");
                }
            }

            ListViewItem lvi = new ListViewItem("") { ImageIndex = imgIndex >= 0 ? imgIndex : -1 };
            lvi.SubItems.Add(title ?? "Unbekannter Titel");
            lvi.SubItems.Add(channel ?? "Unbekannter Kanal");
            lvi.SubItems.Add(duration ?? "");
            lvi.SubItems.Add(webpageUrl ?? "");

            lvMedia.Items.Add(lvi);
            if (lvMedia.Items.Count % 5 == 0)
                lvMedia.EnsureVisible(lvi.Index);
        }

        private async Task<string> RunYtDlpAndGetJson(string url)
        {
            if (!File.Exists(ytDlpPath))
            {
                throw new FileNotFoundException("yt-dlp.exe nicht gefunden!");
            }

            var psi = new ProcessStartInfo
            {
                FileName = ytDlpPath,
                Arguments = $"--dump-single-json --ignore-errors --no-warnings --extractor-retries 5 --user-agent \"Mozilla/5.0\" \"{url}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.UTF8,
                StandardErrorEncoding = Encoding.UTF8
            };

            LogDownload($"yt-dlp Kommando: {psi.FileName} {psi.Arguments}");

            StringBuilder output = new StringBuilder();
            StringBuilder error = new StringBuilder();

            using (Process proc = new Process { StartInfo = psi })
            {
                proc.OutputDataReceived += (s, e) => { if (e.Data != null) output.AppendLine(e.Data); };
                proc.ErrorDataReceived += (s, e) => { if (e.Data != null) error.AppendLine(e.Data); };

                proc.Start();
                proc.BeginOutputReadLine();
                proc.BeginErrorReadLine();

                await Task.Run(() => proc.WaitForExit());

                string fullOutput = output.ToString().Trim();
                string fullError = error.ToString().Trim();

                LogDownload($"STDOUT ({fullOutput.Length} chars): {fullOutput.Substring(0, Math.Min(200, fullOutput.Length))}");
                if (!string.IsNullOrEmpty(fullError))
                    LogDownload($"STDERR ({fullError.Length} chars): {fullError}");

                return fullOutput;
            }
        }
        #endregion

        #region Download - MIT USER TEMPLATE!
        private async Task StartDownload()
        {
            if (lvMedia.Items.Count == 0) return;

            downloadCts = new CancellationTokenSource();
            LockUi(true, $"Download startet mit Template: {tbFileName.Text}");

            try
            {
                string baseFolder = outputFolder ?? GetDefaultDownloadFolder();
                if (isPlaylistCurrent && !string.IsNullOrWhiteSpace(currentPlaylistTitle))
                    baseFolder = Path.Combine(baseFolder, MakeSafeFilename(currentPlaylistTitle));

                Directory.CreateDirectory(baseFolder);

                // 🔥 USER TEMPLATE VERWENDEN!
                string userTemplate = tbFileName.Text.Trim();
                if (string.IsNullOrEmpty(userTemplate))
                {
                    userTemplate = "%(playlist_index)02d_%(title)s-%(uploader)s.%(ext)s"; // Fallback
                    tbFileName.Text = userTemplate;
                }

                string outputTemplate = Path.Combine(baseFolder, userTemplate);
                LogDownload($"Verwende Template: {outputTemplate}");

                string formatArg = rbAudio.Checked
                    ? $"-f bestaudio --extract-audio --audio-format {cbFormat.Text.ToLower()}"
                    : $"-f \"bv*+ba/best\" --merge-output-format {cbFormat.Text.ToLower()}";

                var urls = lvMedia.Items.Cast<ListViewItem>()
                    .Select(i => i.SubItems[4].Text)
                    .Where(u => !string.IsNullOrWhiteSpace(u))
                    .ToList();

                string argUrls = string.Join(" ", urls.Select(u => $"\"{u}\""));
                var psi = new ProcessStartInfo
                {
                    FileName = ytDlpPath,
                    Arguments = $"{formatArg} -o \"{outputTemplate}\" --progress --newline {argUrls}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    StandardOutputEncoding = Encoding.UTF8,
                    StandardErrorEncoding = Encoding.UTF8
                };

                currentDownloadProcess = new Process { StartInfo = psi, EnableRaisingEvents = true };

                currentDownloadProcess.OutputDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        BeginInvoke(new Action(() => { ParseAndShowProgress(e.Data); LogDownload(e.Data); }));
                };

                currentDownloadProcess.ErrorDataReceived += (s, e) =>
                {
                    if (!string.IsNullOrEmpty(e.Data))
                        BeginInvoke(new Action(() => { SetStatus(e.Data, true); LogDownload("[ERROR] " + e.Data); }));
                };

                currentDownloadProcess.Exited += (s, e) => BeginInvoke(new Action(DownloadFinished));

                currentDownloadProcess.Start();
                currentDownloadProcess.BeginOutputReadLine();
                currentDownloadProcess.BeginErrorReadLine();

                await Task.Run(() => currentDownloadProcess.WaitForExit(), downloadCts.Token);
            }
            catch (Exception ex) when (!(ex is OperationCanceledException))
            {
                SetStatus("Fehler beim Download: " + ex.Message, true);
            }
        }

        private void ParseAndShowProgress(string line)
        {
            var match = Regex.Match(line, @"(\d+\.?\d*)%.*at\s+([\d\.]+[a-zA-Z/]+/s)");
            if (match.Success && double.TryParse(match.Groups[1].Value, out double percent))
            {
                pbStatus.Value = Math.Min(100, (int)percent);
                lblStatus.Text = $"Download: {percent:F1}% | Speed: {match.Groups[2].Value}";
            }
            else if (line.Contains("[download]"))
            {
                SetStatus(line.Trim());
            }
        }

        private void DownloadFinished()
        {
            LockUi(false, $"✅ Download abgeschlossen! Template: {tbFileName.Text}");
            LogDownload("=== Download abgeschlossen ===");

            if (cbOpenAfter.Checked)
            {
                string folder = outputFolder ?? GetDefaultDownloadFolder();
                if (Directory.Exists(folder))
                    Process.Start("explorer.exe", folder);
            }

            string action = cbRework.SelectedItem?.ToString() ?? "do nothing";
            SetStatus("Download fertig – Aktion: " + action);
        }
        #endregion

        private void btnDarkmode_Click(object sender, EventArgs e)
        {
            ToggleDarkMode();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(logFilePath))
                {
                    Process.Start("notepad.exe", $"\"{logFilePath}\"");
                    LogDownload("Log geöffnet.");
                }
                else
                {
                    SetStatus("Log-Datei nicht gefunden.", true);
                    LogDownload("Log-Datei nicht gefunden.");
                }
            }
            catch (Exception ex)
            {
                SetStatus("Fehler beim Öffnen des Logs: " + ex.Message, true);
                LogDownload($"Log-Öffnen Fehler: {ex.Message}");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                if (tab.Name == "download")
                {
                    tabControl1.SelectedTab = tab;
                    break;
                }
            }
        }
    }
}