using WinComunity.Models;

namespace WinComunity
{
    public partial class ProfileForm : Form
    {
        public ProfileForm(User user)
        {
            InitializeComponent();
            LoadUserProfile(user);
        }

        private void LoadUserProfile(User user)
        {
            lblFullName.Text = user.FullName;
            lblEmail.Text = $"Пошта: {user.Email}";
            lblPhone.Text = string.IsNullOrWhiteSpace(user.Phone)
                ? "Телефон: не вказано"
                : $"Телефон: {user.Phone}";
            lblBirthDate.Text = $"Дата народження: {user.BirthDate:dd.MM.yyyy}";

            if (user.Photo is not null)
            {
                picAvatar.Image = new Bitmap(user.Photo);
                lblNoPhoto.Visible = false;
            }
            else
            {
                lblNoPhoto.Visible = true;
            }
        }

        private void btnLogout_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
