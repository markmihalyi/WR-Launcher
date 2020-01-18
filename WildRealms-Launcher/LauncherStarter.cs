using System;
using System.Windows.Forms;

namespace LauncherStarter
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WildRealms_Launcher.UpdateChecker());
        }
    }

}