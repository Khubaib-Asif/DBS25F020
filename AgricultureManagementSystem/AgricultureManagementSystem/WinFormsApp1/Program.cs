using AgricultureManagementSystem.Farmer;

namespace AgricultureManagementSystem
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int farmerId = 123;
            Application.Run(new WaterManagemntForm());
        }
    }
}
