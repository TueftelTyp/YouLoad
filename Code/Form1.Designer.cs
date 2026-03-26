namespace YouLoad
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.ListView lvMedia;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.RadioButton rbAudio;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnOpenOutput;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnUrlLoad;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lvMedia = new System.Windows.Forms.ListView();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnOpenOutput = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnUrlLoad = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbRework = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settings = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkProxy = new System.Windows.Forms.CheckBox();
            this.tbProxyTyp = new System.Windows.Forms.TextBox();
            this.tbProxyPass = new System.Windows.Forms.TextBox();
            this.tbProxyUser = new System.Windows.Forms.TextBox();
            this.tbProxyAdress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkAutostart = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numRetry = new System.Windows.Forms.NumericUpDown();
            this.rtbParallel = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkError = new System.Windows.Forms.CheckBox();
            this.numParallel = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnIndex = new System.Windows.Forms.Button();
            this.btnID = new System.Windows.Forms.Button();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnDuration = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnResetName = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnChannel = new System.Windows.Forms.Button();
            this.btnDarkmode = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbOpenAfter = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbSub = new System.Windows.Forms.RichTextBox();
            this.cbSubLang = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkSub = new System.Windows.Forms.CheckBox();
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.chkBest = new System.Windows.Forms.CheckBox();
            this.cbAquality = new System.Windows.Forms.ComboBox();
            this.cbVquality = new System.Windows.Forms.ComboBox();
            this.cbFPS = new System.Windows.Forms.ComboBox();
            this.cbResolution = new System.Windows.Forms.ComboBox();
            this.chkThumb = new System.Windows.Forms.CheckBox();
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.btnLog = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.settings.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParallel)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.download.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(6, 6);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(458, 20);
            this.tbURL.TabIndex = 0;
            // 
            // lvMedia
            // 
            this.lvMedia.HideSelection = false;
            this.lvMedia.Location = new System.Drawing.Point(6, 32);
            this.lvMedia.Name = "lvMedia";
            this.lvMedia.Size = new System.Drawing.Size(622, 300);
            this.lvMedia.TabIndex = 3;
            this.lvMedia.UseCompatibleStateImageBehavior = false;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Checked = true;
            this.rbVideo.Location = new System.Drawing.Point(17, 26);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(52, 17);
            this.rbVideo.TabIndex = 4;
            this.rbVideo.TabStop = true;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Location = new System.Drawing.Point(108, 26);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(52, 17);
            this.rbAudio.TabIndex = 5;
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(89, 150);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 6;
            this.btnOutput.Text = "Destination";
            this.btnOutput.UseVisualStyleBackColor = true;
            // 
            // btnOpenOutput
            // 
            this.btnOpenOutput.Location = new System.Drawing.Point(553, 345);
            this.btnOpenOutput.Name = "btnOpenOutput";
            this.btnOpenOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOpenOutput.TabIndex = 7;
            this.btnOpenOutput.Text = "Output";
            this.btnOpenOutput.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(8, 345);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 23);
            this.btnDownload.TabIndex = 8;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(472, 5);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 1;
            this.btnPaste.Text = "Einfügen";
            this.btnPaste.UseVisualStyleBackColor = true;
            // 
            // btnUrlLoad
            // 
            this.btnUrlLoad.Location = new System.Drawing.Point(553, 4);
            this.btnUrlLoad.Name = "btnUrlLoad";
            this.btnUrlLoad.Size = new System.Drawing.Size(75, 23);
            this.btnUrlLoad.TabIndex = 2;
            this.btnUrlLoad.Text = "Laden";
            this.btnUrlLoad.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.toolStripStatusLabel2,
            this.pbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(645, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(13, 17);
            this.lblStatus.Text = "..";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(415, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // pbStatus
            // 
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(200, 16);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(132, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(447, 345);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // cbRework
            // 
            this.cbRework.FormattingEnabled = true;
            this.cbRework.Location = new System.Drawing.Point(138, 43);
            this.cbRework.Name = "cbRework";
            this.cbRework.Size = new System.Drawing.Size(107, 21);
            this.cbRework.TabIndex = 14;
            this.cbRework.Tag = "";
            this.cbRework.Text = " ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.settings);
            this.tabControl1.Controls.Add(this.download);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(645, 394);
            this.tabControl1.TabIndex = 15;
            // 
            // settings
            // 
            this.settings.Controls.Add(this.groupBox6);
            this.settings.Controls.Add(this.btnSave);
            this.settings.Controls.Add(this.groupBox5);
            this.settings.Controls.Add(this.groupBox4);
            this.settings.Controls.Add(this.groupBox3);
            this.settings.Controls.Add(this.btnDarkmode);
            this.settings.Controls.Add(this.groupBox2);
            this.settings.Controls.Add(this.groupBox1);
            this.settings.Controls.Add(this.btnLog);
            this.settings.Location = new System.Drawing.Point(4, 22);
            this.settings.Name = "settings";
            this.settings.Padding = new System.Windows.Forms.Padding(3);
            this.settings.Size = new System.Drawing.Size(637, 368);
            this.settings.TabIndex = 0;
            this.settings.Text = "Setup";
            this.settings.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkProxy);
            this.groupBox6.Controls.Add(this.tbProxyTyp);
            this.groupBox6.Controls.Add(this.tbProxyPass);
            this.groupBox6.Controls.Add(this.tbProxyUser);
            this.groupBox6.Controls.Add(this.tbProxyAdress);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(8, 282);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(437, 80);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Proxy";
            // 
            // chkProxy
            // 
            this.chkProxy.AutoSize = true;
            this.chkProxy.Location = new System.Drawing.Point(14, 19);
            this.chkProxy.Name = "chkProxy";
            this.chkProxy.Size = new System.Drawing.Size(72, 17);
            this.chkProxy.TabIndex = 5;
            this.chkProxy.Text = "use Proxy";
            this.chkProxy.UseVisualStyleBackColor = true;
            // 
            // tbProxyTyp
            // 
            this.tbProxyTyp.Location = new System.Drawing.Point(14, 45);
            this.tbProxyTyp.Name = "tbProxyTyp";
            this.tbProxyTyp.Size = new System.Drawing.Size(37, 20);
            this.tbProxyTyp.TabIndex = 4;
            this.tbProxyTyp.Text = "http";
            // 
            // tbProxyPass
            // 
            this.tbProxyPass.Location = new System.Drawing.Point(328, 45);
            this.tbProxyPass.Name = "tbProxyPass";
            this.tbProxyPass.PasswordChar = '*';
            this.tbProxyPass.Size = new System.Drawing.Size(100, 20);
            this.tbProxyPass.TabIndex = 3;
            this.tbProxyPass.Text = "password";
            // 
            // tbProxyUser
            // 
            this.tbProxyUser.Location = new System.Drawing.Point(328, 19);
            this.tbProxyUser.Name = "tbProxyUser";
            this.tbProxyUser.Size = new System.Drawing.Size(100, 20);
            this.tbProxyUser.TabIndex = 2;
            this.tbProxyUser.Text = "Username";
            // 
            // tbProxyAdress
            // 
            this.tbProxyAdress.Location = new System.Drawing.Point(57, 45);
            this.tbProxyAdress.Name = "tbProxyAdress";
            this.tbProxyAdress.Size = new System.Drawing.Size(261, 20);
            this.tbProxyAdress.TabIndex = 1;
            this.tbProxyAdress.Text = "proxy.example.com:3128\n";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(498, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 23);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tbUsername);
            this.groupBox5.Controls.Add(this.tbPass);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(451, 198);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(181, 101);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Credentials (optional)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Two-Factor:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(75, 19);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 34;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(75, 46);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(100, 20);
            this.tbPass.TabIndex = 35;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkAutostart);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numRetry);
            this.groupBox4.Controls.Add(this.rtbParallel);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.chkError);
            this.groupBox4.Controls.Add(this.numParallel);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(451, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 183);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Performance";
            // 
            // chkAutostart
            // 
            this.chkAutostart.AutoSize = true;
            this.chkAutostart.Location = new System.Drawing.Point(6, 134);
            this.chkAutostart.Name = "chkAutostart";
            this.chkAutostart.Size = new System.Drawing.Size(112, 17);
            this.chkAutostart.TabIndex = 36;
            this.chkAutostart.Text = "Start when loaded";
            this.chkAutostart.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Retrys:";
            // 
            // numRetry
            // 
            this.numRetry.Location = new System.Drawing.Point(139, 86);
            this.numRetry.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numRetry.Name = "numRetry";
            this.numRetry.Size = new System.Drawing.Size(35, 20);
            this.numRetry.TabIndex = 34;
            // 
            // rtbParallel
            // 
            this.rtbParallel.BackColor = System.Drawing.SystemColors.Info;
            this.rtbParallel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbParallel.Cursor = System.Windows.Forms.Cursors.No;
            this.rtbParallel.Enabled = false;
            this.rtbParallel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.rtbParallel.Location = new System.Drawing.Point(6, 48);
            this.rtbParallel.Name = "rtbParallel";
            this.rtbParallel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbParallel.Size = new System.Drawing.Size(171, 29);
            this.rtbParallel.TabIndex = 33;
            this.rtbParallel.Text = "Number of simultaneous downloads\nHigher = faster, but more CPU/RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "parallel downloads:";
            // 
            // chkError
            // 
            this.chkError.AutoSize = true;
            this.chkError.Location = new System.Drawing.Point(6, 157);
            this.chkError.Name = "chkError";
            this.chkError.Size = new System.Drawing.Size(90, 17);
            this.chkError.TabIndex = 33;
            this.chkError.Text = "Abort on error";
            this.chkError.UseVisualStyleBackColor = true;
            // 
            // numParallel
            // 
            this.numParallel.Location = new System.Drawing.Point(139, 22);
            this.numParallel.Maximum = new decimal(new int[] {
            55,
            0,
            0,
            0});
            this.numParallel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numParallel.Name = "numParallel";
            this.numParallel.Size = new System.Drawing.Size(35, 20);
            this.numParallel.TabIndex = 31;
            this.numParallel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnIndex);
            this.groupBox3.Controls.Add(this.btnID);
            this.groupBox3.Controls.Add(this.tbFileName);
            this.groupBox3.Controls.Add(this.btnOutput);
            this.groupBox3.Controls.Add(this.btnDuration);
            this.groupBox3.Controls.Add(this.btnUnderline);
            this.groupBox3.Controls.Add(this.btnDate);
            this.groupBox3.Controls.Add(this.btnTitle);
            this.groupBox3.Controls.Add(this.btnResetName);
            this.groupBox3.Controls.Add(this.btnMinus);
            this.groupBox3.Controls.Add(this.btnChannel);
            this.groupBox3.Location = new System.Drawing.Point(191, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 184);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Name";
            // 
            // btnIndex
            // 
            this.btnIndex.Location = new System.Drawing.Point(8, 19);
            this.btnIndex.Name = "btnIndex";
            this.btnIndex.Size = new System.Drawing.Size(75, 23);
            this.btnIndex.TabIndex = 21;
            this.btnIndex.Text = "Index";
            this.btnIndex.UseVisualStyleBackColor = true;
            // 
            // btnID
            // 
            this.btnID.Location = new System.Drawing.Point(170, 48);
            this.btnID.Name = "btnID";
            this.btnID.Size = new System.Drawing.Size(75, 23);
            this.btnID.TabIndex = 29;
            this.btnID.Text = "ID";
            this.btnID.UseVisualStyleBackColor = true;
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(8, 115);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(237, 20);
            this.tbFileName.TabIndex = 20;
            // 
            // btnDuration
            // 
            this.btnDuration.Location = new System.Drawing.Point(89, 48);
            this.btnDuration.Name = "btnDuration";
            this.btnDuration.Size = new System.Drawing.Size(75, 23);
            this.btnDuration.TabIndex = 28;
            this.btnDuration.Text = "Duration (s)";
            this.btnDuration.UseVisualStyleBackColor = true;
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(8, 77);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(75, 23);
            this.btnUnderline.TabIndex = 22;
            this.btnUnderline.Text = "_";
            this.btnUnderline.UseVisualStyleBackColor = true;
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(8, 47);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 27;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            // 
            // btnTitle
            // 
            this.btnTitle.Location = new System.Drawing.Point(89, 19);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(75, 23);
            this.btnTitle.TabIndex = 23;
            this.btnTitle.Text = "Title";
            this.btnTitle.UseVisualStyleBackColor = true;
            // 
            // btnResetName
            // 
            this.btnResetName.Location = new System.Drawing.Point(170, 77);
            this.btnResetName.Name = "btnResetName";
            this.btnResetName.Size = new System.Drawing.Size(75, 23);
            this.btnResetName.TabIndex = 26;
            this.btnResetName.Text = ">Reset<";
            this.btnResetName.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(89, 77);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 23);
            this.btnMinus.TabIndex = 24;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnChannel
            // 
            this.btnChannel.Location = new System.Drawing.Point(170, 19);
            this.btnChannel.Name = "btnChannel";
            this.btnChannel.Size = new System.Drawing.Size(75, 23);
            this.btnChannel.TabIndex = 25;
            this.btnChannel.Text = "Channel";
            this.btnChannel.UseVisualStyleBackColor = true;
            // 
            // btnDarkmode
            // 
            this.btnDarkmode.Enabled = false;
            this.btnDarkmode.Location = new System.Drawing.Point(498, 310);
            this.btnDarkmode.Name = "btnDarkmode";
            this.btnDarkmode.Size = new System.Drawing.Size(51, 23);
            this.btnDarkmode.TabIndex = 19;
            this.btnDarkmode.Text = "Theme";
            this.btnDarkmode.UseVisualStyleBackColor = true;
            this.btnDarkmode.Click += new System.EventHandler(this.btnDarkmode_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbRework);
            this.groupBox2.Controls.Add(this.cbOpenAfter);
            this.groupBox2.Location = new System.Drawing.Point(191, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 77);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Follow-up actions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "What else to do?";
            // 
            // cbOpenAfter
            // 
            this.cbOpenAfter.AutoSize = true;
            this.cbOpenAfter.Location = new System.Drawing.Point(11, 23);
            this.cbOpenAfter.Name = "cbOpenAfter";
            this.cbOpenAfter.Size = new System.Drawing.Size(216, 17);
            this.cbOpenAfter.TabIndex = 15;
            this.cbOpenAfter.Text = "open Destination-folder after Download?";
            this.cbOpenAfter.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rtbSub);
            this.groupBox1.Controls.Add(this.cbSubLang);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkSub);
            this.groupBox1.Controls.Add(this.cbOrder);
            this.groupBox1.Controls.Add(this.chkBest);
            this.groupBox1.Controls.Add(this.cbAquality);
            this.groupBox1.Controls.Add(this.cbVquality);
            this.groupBox1.Controls.Add(this.cbFPS);
            this.groupBox1.Controls.Add(this.cbResolution);
            this.groupBox1.Controls.Add(this.chkThumb);
            this.groupBox1.Controls.Add(this.cbFormat);
            this.groupBox1.Controls.Add(this.rbAudio);
            this.groupBox1.Controls.Add(this.rbVideo);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 270);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Format";
            // 
            // rtbSub
            // 
            this.rtbSub.BackColor = System.Drawing.SystemColors.Info;
            this.rtbSub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbSub.Enabled = false;
            this.rtbSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.rtbSub.Location = new System.Drawing.Point(17, 217);
            this.rtbSub.Multiline = false;
            this.rtbSub.Name = "rtbSub";
            this.rtbSub.ReadOnly = true;
            this.rtbSub.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbSub.Size = new System.Drawing.Size(143, 16);
            this.rtbSub.TabIndex = 17;
            this.rtbSub.Text = "only mp4, webm, mkv";
            // 
            // cbSubLang
            // 
            this.cbSubLang.Enabled = false;
            this.cbSubLang.FormattingEnabled = true;
            this.cbSubLang.Location = new System.Drawing.Point(108, 192);
            this.cbSubLang.Name = "cbSubLang";
            this.cbSubLang.Size = new System.Drawing.Size(52, 21);
            this.cbSubLang.TabIndex = 16;
            this.cbSubLang.Text = "de";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Playlistorder:";
            // 
            // chkSub
            // 
            this.chkSub.AutoSize = true;
            this.chkSub.Enabled = false;
            this.chkSub.Location = new System.Drawing.Point(17, 194);
            this.chkSub.Name = "chkSub";
            this.chkSub.Size = new System.Drawing.Size(86, 17);
            this.chkSub.TabIndex = 14;
            this.chkSub.Text = "use Subtitles";
            this.chkSub.UseVisualStyleBackColor = true;
            // 
            // cbOrder
            // 
            this.cbOrder.Enabled = false;
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Location = new System.Drawing.Point(100, 165);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(60, 21);
            this.cbOrder.TabIndex = 13;
            this.cbOrder.Text = "normal";
            // 
            // chkBest
            // 
            this.chkBest.AutoSize = true;
            this.chkBest.Enabled = false;
            this.chkBest.Location = new System.Drawing.Point(27, 110);
            this.chkBest.Name = "chkBest";
            this.chkBest.Size = new System.Drawing.Size(125, 17);
            this.chkBest.TabIndex = 12;
            this.chkBest.Text = "use automatic quality";
            this.chkBest.UseVisualStyleBackColor = true;
            // 
            // cbAquality
            // 
            this.cbAquality.Enabled = false;
            this.cbAquality.FormattingEnabled = true;
            this.cbAquality.Location = new System.Drawing.Point(108, 133);
            this.cbAquality.Name = "cbAquality";
            this.cbAquality.Size = new System.Drawing.Size(52, 21);
            this.cbAquality.TabIndex = 11;
            this.cbAquality.Text = "Best";
            // 
            // cbVquality
            // 
            this.cbVquality.Enabled = false;
            this.cbVquality.FormattingEnabled = true;
            this.cbVquality.Location = new System.Drawing.Point(17, 133);
            this.cbVquality.Name = "cbVquality";
            this.cbVquality.Size = new System.Drawing.Size(52, 21);
            this.cbVquality.TabIndex = 10;
            this.cbVquality.Text = "Best";
            // 
            // cbFPS
            // 
            this.cbFPS.Enabled = false;
            this.cbFPS.FormattingEnabled = true;
            this.cbFPS.Location = new System.Drawing.Point(108, 83);
            this.cbFPS.Name = "cbFPS";
            this.cbFPS.Size = new System.Drawing.Size(52, 21);
            this.cbFPS.TabIndex = 9;
            this.cbFPS.Text = "30";
            // 
            // cbResolution
            // 
            this.cbResolution.Enabled = false;
            this.cbResolution.FormattingEnabled = true;
            this.cbResolution.Location = new System.Drawing.Point(17, 83);
            this.cbResolution.Name = "cbResolution";
            this.cbResolution.Size = new System.Drawing.Size(52, 21);
            this.cbResolution.TabIndex = 8;
            this.cbResolution.Text = "1080p";
            // 
            // chkThumb
            // 
            this.chkThumb.AutoSize = true;
            this.chkThumb.Enabled = false;
            this.chkThumb.Location = new System.Drawing.Point(38, 242);
            this.chkThumb.Name = "chkThumb";
            this.chkThumb.Size = new System.Drawing.Size(106, 17);
            this.chkThumb.TabIndex = 7;
            this.chkThumb.Text = "save Thumbnails";
            this.chkThumb.UseVisualStyleBackColor = true;
            // 
            // cbFormat
            // 
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Location = new System.Drawing.Point(17, 56);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(143, 21);
            this.cbFormat.TabIndex = 6;
            this.cbFormat.Text = "MP4";
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(555, 310);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(35, 23);
            this.btnLog.TabIndex = 16;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // download
            // 
            this.download.Controls.Add(this.btnReset);
            this.download.Controls.Add(this.btnOpenOutput);
            this.download.Controls.Add(this.lvMedia);
            this.download.Controls.Add(this.btnCancel);
            this.download.Controls.Add(this.btnUrlLoad);
            this.download.Controls.Add(this.btnDownload);
            this.download.Controls.Add(this.btnPaste);
            this.download.Controls.Add(this.tbURL);
            this.download.Location = new System.Drawing.Point(4, 22);
            this.download.Name = "download";
            this.download.Padding = new System.Windows.Forms.Padding(3);
            this.download.Size = new System.Drawing.Size(637, 368);
            this.download.TabIndex = 1;
            this.download.Text = "Download";
            this.download.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(645, 421);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouLoad";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.settings.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numParallel)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.download.ResumeLayout(false);
            this.download.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbRework;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settings;
        private System.Windows.Forms.TabPage download;
        private System.Windows.Forms.CheckBox cbOpenAfter;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDarkmode;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnIndex;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnID;
        private System.Windows.Forms.Button btnDuration;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnResetName;
        private System.Windows.Forms.Button btnChannel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numParallel;
        private System.Windows.Forms.RichTextBox rtbParallel;
        private System.Windows.Forms.CheckBox chkError;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numRetry;
        private System.Windows.Forms.CheckBox chkAutostart;
        private System.Windows.Forms.ComboBox cbFPS;
        private System.Windows.Forms.ComboBox cbResolution;
        private System.Windows.Forms.CheckBox chkThumb;
        private System.Windows.Forms.ComboBox cbVquality;
        private System.Windows.Forms.CheckBox chkBest;
        private System.Windows.Forms.ComboBox cbAquality;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.ComboBox cbSubLang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSub;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbProxyTyp;
        private System.Windows.Forms.TextBox tbProxyPass;
        private System.Windows.Forms.TextBox tbProxyUser;
        private System.Windows.Forms.TextBox tbProxyAdress;
        private System.Windows.Forms.RichTextBox rtbSub;
        private System.Windows.Forms.CheckBox chkProxy;
    }
}
