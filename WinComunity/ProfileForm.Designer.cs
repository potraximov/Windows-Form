namespace WinComunity
{
    partial class ProfileForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            picAvatar = new PictureBox();
            lblNoPhoto = new Label();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblBirthDate = new Label();
            btnLogout = new Button();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(540, 74);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(26, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Профіль користувача";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.FromArgb(226, 232, 240);
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(28, 98);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(170, 170);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 1;
            picAvatar.TabStop = false;
            // 
            // lblNoPhoto
            // 
            lblNoPhoto.BackColor = Color.Transparent;
            lblNoPhoto.Font = new Font("Segoe UI", 9.5F);
            lblNoPhoto.ForeColor = Color.FromArgb(100, 116, 139);
            lblNoPhoto.Location = new Point(38, 165);
            lblNoPhoto.Name = "lblNoPhoto";
            lblNoPhoto.Size = new Size(150, 36);
            lblNoPhoto.TabIndex = 2;
            lblNoPhoto.Text = "Фото відсутнє";
            lblNoPhoto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(15, 23, 42);
            lblFullName.Location = new Point(220, 102);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(120, 25);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Ім'я Прізвище";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.5F);
            lblEmail.ForeColor = Color.FromArgb(51, 65, 85);
            lblEmail.Location = new Point(222, 144);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(150, 19);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Пошта: ...";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10.5F);
            lblPhone.ForeColor = Color.FromArgb(51, 65, 85);
            lblPhone.Location = new Point(222, 176);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(150, 19);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Телефон: ...";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 10.5F);
            lblBirthDate.ForeColor = Color.FromArgb(51, 65, 85);
            lblBirthDate.Location = new Point(222, 208);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(180, 19);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "Дата народження: ...";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(220, 38, 38);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(320, 276);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(190, 40);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Вийти з акаунта";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(540, 340);
            Controls.Add(btnLogout);
            Controls.Add(lblBirthDate);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(lblNoPhoto);
            Controls.Add(picAvatar);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Профіль — WinComunity";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader = null!;
        private Label lblTitle = null!;
        private PictureBox picAvatar = null!;
        private Label lblNoPhoto = null!;
        private Label lblFullName = null!;
        private Label lblEmail = null!;
        private Label lblPhone = null!;
        private Label lblBirthDate = null!;
        private Button btnLogout = null!;
    }
}
