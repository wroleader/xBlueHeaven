namespace xBlueHeaven
{
    partial class SkeetControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkeetControl));
            imgUserAvatar = new PictureBox();
            lblUser = new Label();
            lblHandle = new Label();
            tblUserHandle = new TableLayoutPanel();
            lblSkeetContent = new Label();
            pnlSkeetContent = new Panel();
            btnReplies = new Button();
            btnReskeet = new Button();
            btnLike = new Button();
            ((System.ComponentModel.ISupportInitialize)imgUserAvatar).BeginInit();
            tblUserHandle.SuspendLayout();
            pnlSkeetContent.SuspendLayout();
            SuspendLayout();
            // 
            // imgUserAvatar
            // 
            imgUserAvatar.BackColor = Color.Transparent;
            imgUserAvatar.BorderStyle = BorderStyle.FixedSingle;
            imgUserAvatar.Location = new Point(17, 17);
            imgUserAvatar.Name = "imgUserAvatar";
            imgUserAvatar.Size = new Size(60, 60);
            imgUserAvatar.TabIndex = 0;
            imgUserAvatar.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoEllipsis = true;
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.FlatStyle = FlatStyle.Flat;
            lblUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblUser.Location = new Point(4, 1);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(121, 26);
            lblUser.TabIndex = 0;
            lblUser.Text = "Namey McNamara";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHandle
            // 
            lblHandle.Dock = DockStyle.Fill;
            lblHandle.FlatStyle = FlatStyle.Flat;
            lblHandle.Font = new Font("Segoe UI Semilight", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblHandle.Location = new Point(132, 1);
            lblHandle.Name = "lblHandle";
            lblHandle.Size = new Size(345, 26);
            lblHandle.TabIndex = 1;
            lblHandle.Text = "@username.domain.something";
            lblHandle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tblUserHandle
            // 
            tblUserHandle.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblUserHandle.ColumnCount = 2;
            tblUserHandle.ColumnStyles.Add(new ColumnStyle());
            tblUserHandle.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblUserHandle.Controls.Add(lblHandle, 1, 0);
            tblUserHandle.Controls.Add(lblUser, 0, 0);
            tblUserHandle.Location = new Point(83, 17);
            tblUserHandle.Name = "tblUserHandle";
            tblUserHandle.RowCount = 1;
            tblUserHandle.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblUserHandle.Size = new Size(481, 28);
            tblUserHandle.TabIndex = 2;
            // 
            // lblSkeetContent
            // 
            lblSkeetContent.Dock = DockStyle.Fill;
            lblSkeetContent.FlatStyle = FlatStyle.Flat;
            lblSkeetContent.Location = new Point(0, 0);
            lblSkeetContent.Name = "lblSkeetContent";
            lblSkeetContent.Size = new Size(479, 94);
            lblSkeetContent.TabIndex = 3;
            lblSkeetContent.Text = resources.GetString("lblSkeetContent.Text");
            lblSkeetContent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlSkeetContent
            // 
            pnlSkeetContent.BorderStyle = BorderStyle.FixedSingle;
            pnlSkeetContent.Controls.Add(lblSkeetContent);
            pnlSkeetContent.Location = new Point(83, 46);
            pnlSkeetContent.Name = "pnlSkeetContent";
            pnlSkeetContent.Size = new Size(481, 96);
            pnlSkeetContent.TabIndex = 4;
            // 
            // btnReplies
            // 
            btnReplies.FlatStyle = FlatStyle.Flat;
            btnReplies.Location = new Point(83, 151);
            btnReplies.Name = "btnReplies";
            btnReplies.Size = new Size(29, 29);
            btnReplies.TabIndex = 5;
            btnReplies.UseVisualStyleBackColor = true;
            // 
            // btnReskeet
            // 
            btnReskeet.FlatStyle = FlatStyle.Flat;
            btnReskeet.Location = new Point(235, 151);
            btnReskeet.Name = "btnReskeet";
            btnReskeet.Size = new Size(29, 29);
            btnReskeet.TabIndex = 6;
            btnReskeet.UseVisualStyleBackColor = true;
            // 
            // btnLike
            // 
            btnLike.FlatStyle = FlatStyle.Flat;
            btnLike.Location = new Point(387, 151);
            btnLike.Name = "btnLike";
            btnLike.Size = new Size(29, 29);
            btnLike.TabIndex = 7;
            btnLike.UseVisualStyleBackColor = true;
            // 
            // SkeetControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnLike);
            Controls.Add(btnReskeet);
            Controls.Add(btnReplies);
            Controls.Add(pnlSkeetContent);
            Controls.Add(tblUserHandle);
            Controls.Add(imgUserAvatar);
            ForeColor = Color.White;
            Name = "SkeetControl";
            Size = new Size(578, 188);
            ((System.ComponentModel.ISupportInitialize)imgUserAvatar).EndInit();
            tblUserHandle.ResumeLayout(false);
            tblUserHandle.PerformLayout();
            pnlSkeetContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgUserAvatar;
        private Label lblUser;
        private Label lblHandle;
        private TableLayoutPanel tblUserHandle;
        private Label lblSkeetContent;
        private Panel pnlSkeetContent;
        private Button btnReplies;
        private Button btnReskeet;
        private Button btnLike;
    }
}
