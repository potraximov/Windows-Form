namespace WinComunity
{
    internal static class Program
    {
        /// <summary>
        /// Головна точка входу для застосунку.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
