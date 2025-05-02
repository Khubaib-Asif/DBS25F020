namespace AgricultureManagementSystem
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignUpForm()); // Set LoginForm as the startup form
        }
    }
}
