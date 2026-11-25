using System.Drawing;

namespace WinComunity.Models
{
    /// <summary>
    /// Модель зареєстрованого користувача.
    /// </summary>
    public class User
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Password { get; set; } = string.Empty;
        public string? PhotoPath { get; set; }
        public Image? Photo { get; set; }
    }

    /// <summary>
    /// Тимчасове сховище користувачів у пам'яті застосунку.
    /// </summary>
    public static class UserStore
    {
        private static readonly List<User> _users = new()
        {
            new User
            {
                FullName = "Демо Користувач",
                Email = "demo@example.com",
                Phone = "+380991234567",
                BirthDate = new DateTime(2005, 5, 15),
                Password = "password123"
            }
        };

        public static bool EmailExists(string email) =>
            _users.Any(u => u.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase));

        public static void AddUser(User user) => _users.Add(user);

        public static User? Authenticate(string email, string password) =>
            _users.FirstOrDefault(u =>
                u.Email.Equals(email.Trim(), StringComparison.OrdinalIgnoreCase) &&
                u.Password == password);

        /// <summary>
        /// Завантажує зображення у пам'ять без блокування файлу на диску.
        /// </summary>
        public static Image LoadImageCopy(string filePath)
        {
            byte[] bytes = File.ReadAllBytes(filePath);
            using var ms = new MemoryStream(bytes);
            using var temp = Image.FromStream(ms);
            return new Bitmap(temp);
        }
    }
}
