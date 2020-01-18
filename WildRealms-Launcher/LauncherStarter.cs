using System;
using System.Windows.Forms;

namespace LauncherStarter
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new WildRealms_Launcher.UpdateChecker());
        }
    }

}