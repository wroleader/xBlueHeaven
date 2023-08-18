namespace xBlueHeaven
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlSidebar = new Panel();
            pBar = new CircularProgressBar.CircularProgressBar();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHome = new Button();
            btnSearch = new Button();
            btnFeeds = new Button();
            btnNotifications = new Button();
            btnProfile = new Button();
            btnSettings = new Button();
            pnlTitlebar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            lblTitle = new Label();
            btnLogin = new Button();
            txtHandle = new TextBox();
            txtPwd = new TextBox();
            chkRemember = new CheckBox();
            chkAppPw = new CheckBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            pnlTitlebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.Black;
            pnlSidebar.BorderStyle = BorderStyle.FixedSingle;
            pnlSidebar.Controls.Add(pBar);
            pnlSidebar.Controls.Add(flowLayoutPanel1);
            pnlSidebar.Controls.Add(btnHome);
            pnlSidebar.Controls.Add(btnSearch);
            pnlSidebar.Controls.Add(btnFeeds);
            pnlSidebar.Controls.Add(btnNotifications);
            pnlSidebar.Controls.Add(btnProfile);
            pnlSidebar.Controls.Add(btnSettings);
            pnlSidebar.Location = new Point(-1, 2);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(46, 451);
            pnlSidebar.TabIndex = 0;
            // 
            // pBar
            // 
            pBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.SinusoidalEaseIn;
            pBar.AnimationSpeed = 500;
            pBar.BackColor = Color.Transparent;
            pBar.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            pBar.ForeColor = Color.FromArgb(64, 64, 64);
            pBar.InnerColor = Color.FromArgb(224, 224, 224);
            pBar.InnerMargin = 2;
            pBar.InnerWidth = -1;
            pBar.Location = new Point(1, 404);
            pBar.MarqueeAnimationSpeed = 2000;
            pBar.Name = "pBar";
            pBar.OuterColor = Color.Gray;
            pBar.OuterMargin = -25;
            pBar.OuterWidth = 26;
            pBar.ProgressColor = Color.FromArgb(0, 192, 192);
            pBar.ProgressWidth = 25;
            pBar.SecondaryFont = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            pBar.Size = new Size(42, 42);
            pBar.StartAngle = 270;
            pBar.SubscriptColor = Color.FromArgb(166, 166, 166);
            pBar.SubscriptMargin = new Padding(10, -35, 0, 0);
            pBar.SubscriptText = "";
            pBar.SuperscriptColor = Color.FromArgb(166, 166, 166);
            pBar.SuperscriptMargin = new Padding(10, 35, 0, 0);
            pBar.SuperscriptText = "";
            pBar.TabIndex = 0;
            pBar.TextMargin = new Padding(8, 8, 0, 0);
            pBar.Value = 68;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(50, -1);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(633, 425);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btnHome
            // 
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnHome.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Image = Assets.home;
            btnHome.Location = new Point(0, 24);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(42, 43);
            btnHome.TabIndex = 0;
            btnHome.TabStop = false;
            btnHome.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnSearch.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Image = Assets.search;
            btnSearch.Location = new Point(0, 65);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(42, 43);
            btnSearch.TabIndex = 1;
            btnSearch.TabStop = false;
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnFeeds
            // 
            btnFeeds.FlatAppearance.BorderSize = 0;
            btnFeeds.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnFeeds.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnFeeds.FlatStyle = FlatStyle.Flat;
            btnFeeds.Image = Assets.myfeeds;
            btnFeeds.Location = new Point(0, 106);
            btnFeeds.Name = "btnFeeds";
            btnFeeds.Size = new Size(42, 43);
            btnFeeds.TabIndex = 2;
            btnFeeds.TabStop = false;
            btnFeeds.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            btnNotifications.FlatAppearance.BorderSize = 0;
            btnNotifications.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnNotifications.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnNotifications.FlatStyle = FlatStyle.Flat;
            btnNotifications.Image = Assets.notifications;
            btnNotifications.Location = new Point(0, 147);
            btnNotifications.Name = "btnNotifications";
            btnNotifications.Size = new Size(42, 43);
            btnNotifications.TabIndex = 3;
            btnNotifications.TabStop = false;
            btnNotifications.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Image = Assets.profile;
            btnProfile.Location = new Point(0, 188);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(42, 43);
            btnProfile.TabIndex = 4;
            btnProfile.TabStop = false;
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseDownBackColor = Color.Silver;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Image = Assets.settings;
            btnSettings.Location = new Point(0, 229);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(42, 43);
            btnSettings.TabIndex = 5;
            btnSettings.TabStop = false;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // pnlTitlebar
            // 
            pnlTitlebar.Controls.Add(btnMinimize);
            pnlTitlebar.Controls.Add(btnClose);
            pnlTitlebar.Controls.Add(lblTitle);
            pnlTitlebar.Location = new Point(-1, -1);
            pnlTitlebar.Name = "pnlTitlebar";
            pnlTitlebar.Size = new Size(687, 30);
            pnlTitlebar.TabIndex = 1;
            // 
            // btnMinimize
            // 
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatAppearance.MouseDownBackColor = Color.Gray;
            btnMinimize.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(610, -3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(38, 31);
            btnMinimize.TabIndex = 3;
            btnMinimize.TabStop = false;
            btnMinimize.Text = "🗕";
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(648, -3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(38, 31);
            btnClose.TabIndex = 2;
            btnClose.TabStop = false;
            btnClose.Text = "✖";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitle
            // 
            lblTitle.BorderStyle = BorderStyle.FixedSingle;
            lblTitle.FlatStyle = FlatStyle.Flat;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(684, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "BlueHeaven - {Location} - {@userhandle.bsky.social}";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.MouseMove += lblTitle_MouseMove;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(269, 233);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(147, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtHandle
            // 
            txtHandle.Location = new Point(269, 175);
            txtHandle.Name = "txtHandle";
            txtHandle.PlaceholderText = "Handle";
            txtHandle.Size = new Size(147, 23);
            txtHandle.TabIndex = 3;
            txtHandle.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(269, 204);
            txtPwd.Name = "txtPwd";
            txtPwd.PasswordChar = '*';
            txtPwd.PlaceholderText = "App Password";
            txtPwd.Size = new Size(147, 23);
            txtPwd.TabIndex = 4;
            txtPwd.TextAlign = HorizontalAlignment.Center;
            // 
            // chkRemember
            // 
            chkRemember.CheckAlign = ContentAlignment.BottomCenter;
            chkRemember.FlatAppearance.BorderSize = 0;
            chkRemember.FlatStyle = FlatStyle.Flat;
            chkRemember.Location = new Point(248, 273);
            chkRemember.Name = "chkRemember";
            chkRemember.Size = new Size(88, 34);
            chkRemember.TabIndex = 5;
            chkRemember.Text = "Save Account";
            chkRemember.TextAlign = ContentAlignment.TopCenter;
            chkRemember.UseVisualStyleBackColor = true;
            // 
            // chkAppPw
            // 
            chkAppPw.CheckAlign = ContentAlignment.BottomCenter;
            chkAppPw.Checked = true;
            chkAppPw.CheckState = CheckState.Checked;
            chkAppPw.FlatAppearance.BorderSize = 0;
            chkAppPw.FlatStyle = FlatStyle.Flat;
            chkAppPw.Location = new Point(337, 273);
            chkAppPw.Name = "chkAppPw";
            chkAppPw.Size = new Size(109, 34);
            chkAppPw.TabIndex = 6;
            chkAppPw.Text = "Use App Password";
            chkAppPw.TextAlign = ContentAlignment.TopCenter;
            chkAppPw.UseVisualStyleBackColor = true;
            chkAppPw.CheckedChanged += chkAppPw_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 600;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(685, 450);
            Controls.Add(chkAppPw);
            Controls.Add(chkRemember);
            Controls.Add(txtPwd);
            Controls.Add(txtHandle);
            Controls.Add(btnLogin);
            Controls.Add(pnlTitlebar);
            Controls.Add(pnlSidebar);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Contrails";
            Load += Form1_Load;
            pnlSidebar.ResumeLayout(false);
            pnlTitlebar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button btnHome;
        private Button btnSearch;
        private Button btnSettings;
        private Button btnProfile;
        private Button btnNotifications;
        private Button btnFeeds;
        private Panel pnlTitlebar;
        private Label lblTitle;
        private Button btnClose;
        private Button btnMinimize;
        private FlowLayoutPanel flowLayoutPanel1;
        private CircularProgressBar.CircularProgressBar pBar;
        private Button btnLogin;
        private TextBox txtHandle;
        private TextBox txtPwd;
        private CheckBox chkRemember;
        private CheckBox chkAppPw;
        private System.Windows.Forms.Timer timer1;
    }
}