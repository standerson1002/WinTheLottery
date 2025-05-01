using GameObjects;

namespace PresentationLayer
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            AppData.DataPath = Application.StartupPath + "savefile\\";

            ApplicationConfiguration.Initialize();
            Application.Run(new frmMain());
            //frmMain mainForm = new frmMain();
            // Application.Run(mainForm);
        }
    }
}