using WinComunity.Models;

namespace WinComunity
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object? sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnRegister_Click(object? sender, EventArgs e)
        {
            Hide();
            using var registerForm = new RegisterForm();
            if (registerForm.ShowDialog(this) == DialogResult.OK && !string.IsNullOrWhiteSpace(registerForm.RegisteredEmail))
            {
                txtEmail.Text = registerForm.RegisteredEmail;
                txtPassword.Clear();
                txtPassword.Focus();
            }
            Show();
        }

        private void btnLogin_Click(object? sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Будь ласка, заповніть електронну пошту та пароль.",
                    "Помилка входу",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            User? user = UserStore.Authenticate(email, password);
            if (user is null)
            {
                MessageBox.Show(
                    "Невірна електронна пошта або пароль.",
                    "Помилка входу",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Hide();
            using var profileForm = new ProfileForm(user);
            profileForm.ShowDialog(this);
            txtPassword.Clear();
            Show();
        }
    }
}
