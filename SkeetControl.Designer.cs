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
            imgUserAvatar = new PictureBox();
            lblUser = new Label();
            lblHandle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)imgUserAvatar).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            lblUser.Location = new Point(3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(190, 28);
            lblUser.TabIndex = 0;
            lblUser.Text = "Someone who's name is lmao";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHandle
            // 
            lblHandle.Dock = DockStyle.Fill;
            lblHandle.FlatStyle = FlatStyle.Flat;
            lblHandle.Font = new Font("Segoe UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHandle.Location = new Point(199, 0);
            lblHandle.Name = "lblHandle";
            lblHandle.Size = new Size(279, 28);
            lblHandle.TabIndex = 1;
            lblHandle.Text = "@";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblHandle, 1, 0);
            tableLayoutPanel1.Controls.Add(lblUser, 0, 0);
            tableLayoutPanel1.Location = new Point(83, 17);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(481, 28);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // SkeetControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(imgUserAvatar);
            ForeColor = Color.White;
            Name = "SkeetControl";
            Size = new Size(578, 188);
            ((System.ComponentModel.ISupportInitialize)imgUserAvatar).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox imgUserAvatar;
        private Label lblUser;
        private Label lblHandle;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
