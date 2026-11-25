namespace WinComunity
{
    partial class RegisterForm
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
            lblSubtitle = new Label();
            lblTitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            chkShowPassword = new CheckBox();
            pnlPhoto = new Panel();
            lblPhotoTitle = new Label();
            picAvatar = new PictureBox();
            lblPhotoStatus = new Label();
            btnSelectPhoto = new Button();
            btnClearPhoto = new Button();
            btnBackToLogin = new Button();
            btnRegister = new Button();
            pnlHeader.SuspendLayout();
            pnlPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(30, 41, 59);
            pnlHeader.Controls.Add(lblSubtitle);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(720, 84);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(28, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(271, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Реєстрація користувача";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(203, 213, 225);
            lblSubtitle.Location = new Point(30, 48);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(321, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Створіть обліковий запис та оберіть фото профілю";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(51, 65, 85);
            lblFullName.Location = new Point(30, 102);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(134, 19);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Прізвище та ім'я *";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 10.5F);
            txtFullName.Location = new Point(30, 124);
            txtFullName.Name = "txtFullName";
            txtFullName.PlaceholderText = "Іваненко Іван";
            txtFullName.Size = new Size(375, 26);
            txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(51, 65, 85);
            lblEmail.Location = new Point(30, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(149, 19);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Електронна пошта *";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10.5F);
            txtEmail.Location = new Point(30, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "example@gmail.com";
            txtEmail.Size = new Size(375, 26);
            txtEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone.ForeColor = Color.FromArgb(51, 65, 85);
            lblPhone.Location = new Point(30, 218);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(127, 19);
            lblPhone.TabIndex = 5;
            lblPhone.Text = "Номер телефону";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10.5F);
            txtPhone.Location = new Point(30, 240);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "+380991234567";
            txtPhone.Size = new Size(190, 26);
            txtPhone.TabIndex = 6;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBirthDate.ForeColor = Color.FromArgb(51, 65, 85);
            lblBirthDate.Location = new Point(235, 218);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(134, 19);
            lblBirthDate.TabIndex = 7;
            lblBirthDate.Text = "Дата народження";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Font = new Font("Segoe UI", 10.5F);
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(235, 240);
            dtpBirthDate.MaxDate = new DateTime(2026, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(170, 26);
            dtpBirthDate.TabIndex = 8;
            dtpBirthDate.Value = new DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblPassword.Location = new Point(30, 276);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(71, 19);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Пароль *";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 10.5F);
            txtPassword.Location = new Point(30, 298);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(375, 26);
            txtPassword.TabIndex = 10;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(51, 65, 85);
            lblConfirmPassword.Location = new Point(30, 334);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(172, 19);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Підтвердження пароля *";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 10.5F);
            txtConfirmPassword.Location = new Point(30, 356);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(375, 26);
            txtConfirmPassword.TabIndex = 12;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Segoe UI", 9.5F);
            chkShowPassword.ForeColor = Color.FromArgb(71, 85, 105);
            chkShowPassword.Location = new Point(30, 392);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(134, 21);
            chkShowPassword.TabIndex = 13;
            chkShowPassword.Text = "Показати пароль";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // pnlPhoto
            // 
            pnlPhoto.BackColor = Color.White;
            pnlPhoto.BorderStyle = BorderStyle.FixedSingle;
            pnlPhoto.Controls.Add(btnClearPhoto);
            pnlPhoto.Controls.Add(btnSelectPhoto);
            pnlPhoto.Controls.Add(lblPhotoStatus);
            pnlPhoto.Controls.Add(picAvatar);
            pnlPhoto.Controls.Add(lblPhotoTitle);
            pnlPhoto.Location = new Point(435, 102);
            pnlPhoto.Name = "pnlPhoto";
            pnlPhoto.Size = new Size(255, 326);
            pnlPhoto.TabIndex = 14;
            // 
            // lblPhotoTitle
            // 
            lblPhotoTitle.AutoSize = true;
            lblPhotoTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblPhotoTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblPhotoTitle.Location = new Point(16, 12);
            lblPhotoTitle.Name = "lblPhotoTitle";
            lblPhotoTitle.Size = new Size(115, 19);
            lblPhotoTitle.TabIndex = 0;
            lblPhotoTitle.Text = "Фото профілю";
            // 
            // picAvatar
            // 
            picAvatar.BackColor = Color.FromArgb(241, 245, 249);
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(26, 40);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(200, 190);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 1;
            picAvatar.TabStop = false;
            // 
            // lblPhotoStatus
            // 
            lblPhotoStatus.Font = new Font("Segoe UI", 8.5F);
            lblPhotoStatus.ForeColor = Color.FromArgb(100, 116, 139);
            lblPhotoStatus.Location = new Point(16, 238);
            lblPhotoStatus.Name = "lblPhotoStatus";
            lblPhotoStatus.Size = new Size(220, 22);
            lblPhotoStatus.TabIndex = 2;
            lblPhotoStatus.Text = "Фото не обрано";
            lblPhotoStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelectPhoto
            // 
            btnSelectPhoto.BackColor = Color.FromArgb(14, 165, 233);
            btnSelectPhoto.Cursor = Cursors.Hand;
            btnSelectPhoto.FlatAppearance.BorderSize = 0;
            btnSelectPhoto.FlatStyle = FlatStyle.Flat;
            btnSelectPhoto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSelectPhoto.ForeColor = Color.White;
            btnSelectPhoto.Location = new Point(26, 268);
            btnSelectPhoto.Name = "btnSelectPhoto";
            btnSelectPhoto.Size = new Size(124, 38);
            btnSelectPhoto.TabIndex = 3;
            btnSelectPhoto.Text = "Обрати фото...";
            btnSelectPhoto.UseVisualStyleBackColor = false;
            btnSelectPhoto.Click += btnSelectPhoto_Click;
            // 
            // btnClearPhoto
            // 
            btnClearPhoto.BackColor = Color.FromArgb(226, 232, 240);
            btnClearPhoto.Cursor = Cursors.Hand;
            btnClearPhoto.FlatAppearance.BorderSize = 0;
            btnClearPhoto.FlatStyle = FlatStyle.Flat;
            btnClearPhoto.Font = new Font("Segoe UI", 9.5F);
            btnClearPhoto.ForeColor = Color.FromArgb(51, 65, 85);
            btnClearPhoto.Location = new Point(156, 268);
            btnClearPhoto.Name = "btnClearPhoto";
            btnClearPhoto.Size = new Size(70, 38);
            btnClearPhoto.TabIndex = 4;
            btnClearPhoto.Text = "Скинути";
            btnClearPhoto.UseVisualStyleBackColor = false;
            btnClearPhoto.Click += btnClearPhoto_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.BackColor = Color.FromArgb(226, 232, 240);
            btnBackToLogin.Cursor = Cursors.Hand;
            btnBackToLogin.FlatAppearance.BorderSize = 0;
            btnBackToLogin.FlatStyle = FlatStyle.Flat;
            btnBackToLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnBackToLogin.ForeColor = Color.FromArgb(30, 41, 59);
            btnBackToLogin.Location = new Point(30, 448);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(180, 42);
            btnBackToLogin.TabIndex = 15;
            btnBackToLogin.Text = "← Назад до входу";
            btnBackToLogin.UseVisualStyleBackColor = false;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(22, 163, 74);
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(435, 448);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(255, 42);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Зареєструватися";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(720, 515);
            Controls.Add(btnRegister);
            Controls.Add(btnBackToLogin);
            Controls.Add(pnlPhoto);
            Controls.Add(chkShowPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Реєстрація — WinComunity";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlPhoto.ResumeLayout(false);
            pnlPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader = null!;
        private Label lblTitle = null!;
        private Label lblSubtitle = null!;
        private Label lblFullName = null!;
        private TextBox txtFullName = null!;
        private Label lblEmail = null!;
        private TextBox txtEmail = null!;
        private Label lblPhone = null!;
        private TextBox txtPhone = null!;
        private Label lblBirthDate = null!;
        private DateTimePicker dtpBirthDate = null!;
        private Label lblPassword = null!;
        private TextBox txtPassword = null!;
        private Label lblConfirmPassword = null!;
        private TextBox txtConfirmPassword = null!;
        private CheckBox chkShowPassword = null!;
        private Panel pnlPhoto = null!;
        private Label lblPhotoTitle = null!;
        private PictureBox picAvatar = null!;
        private Label lblPhotoStatus = null!;
        private Button btnSelectPhoto = null!;
        private Button btnClearPhoto = null!;
        private Button btnBackToLogin = null!;
        private Button btnRegister = null!;
    }
}
