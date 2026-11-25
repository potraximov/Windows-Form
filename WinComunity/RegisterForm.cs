using System.Net.Mail;
using WinComunity.Models;

namespace WinComunity
{
    public partial class RegisterForm : Form
    {
        private string? _selectedPhotoPath;

        public string? RegisteredEmail { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;
            txtPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }

        private void btnSelectPhoto_Click(object? sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Оберіть фото профілю",
                Filter = "Зображення (*.jpg;*.jpeg;*.png;*.bmp;*.gif)|*.jpg;*.jpeg;*.png;*.bmp;*.gif|Усі файли (*.*)|*.*"
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                Image newImage = UserStore.LoadImageCopy(dialog.FileName);
                picAvatar.Image?.Dispose();
                picAvatar.Image = newImage;
                _selectedPhotoPath = dialog.FileName;
                lblPhotoStatus.Text = Path.GetFileName(dialog.FileName);
                lblPhotoStatus.ForeColor = Color.FromArgb(22, 163, 74);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не вдалося завантажити зображення: {ex.Message}",
                    "Помилка завантаження фото",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClearPhoto_Click(object? sender, EventArgs e)
        {
            picAvatar.Image?.Dispose();
            picAvatar.Image = null;
            _selectedPhotoPath = null;
            lblPhotoStatus.Text = "Фото не обрано";
            lblPhotoStatus.ForeColor = Color.FromArgb(100, 116, 139);
        }

        private void btnBackToLogin_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(fullName))
            {
                ShowValidationError("Введіть прізвище та ім'я.", txtFullName);
                return;
            }

            if (!IsValidEmail(email))
            {
                ShowValidationError("Введіть коректну електронну пошту.", txtEmail);
                return;
            }

            if (UserStore.EmailExists(email))
            {
                ShowValidationError("Користувач із такою електронною поштою вже існує.", txtEmail);
                return;
            }

            if (password.Length < 6)
            {
                ShowValidationError("Пароль має містити щонайменше 6 символів.", txtPassword);
                return;
            }

            if (password != confirmPassword)
            {
                ShowValidationError("Паролі не співпадають.", txtConfirmPassword);
                return;
            }

            var newUser = new User
            {
                FullName = fullName,
                Email = email,
                Phone = phone,
                BirthDate = dtpBirthDate.Value.Date,
                Password = password,
                PhotoPath = _selectedPhotoPath,
                Photo = picAvatar.Image is not null ? new Bitmap(picAvatar.Image) : null
            };

            UserStore.AddUser(newUser);
            RegisteredEmail = newUser.Email;

            MessageBox.Show(
                $"Користувача {newUser.FullName} успішно зареєстровано!",
                "Реєстрація завершена",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
            Close();
        }

        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ShowValidationError(string message, Control targetControl)
        {
            MessageBox.Show(message, "Перевірка даних", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            targetControl.Focus();
        }
    }
}
