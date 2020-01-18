using Microsoft.Azure.Amqp.Transaction;
using System;
using System.Threading;
using System.Windows.Forms;
using WildRealms_Launcher.Screens;

namespace WildRealms_Launcher
{
    public partial class UpdateChecker : Form
    {
        public UpdateChecker()
        {
            InitializeComponent();
        }

        private void UpdateChecker_Load(object sender, EventArgs e)
        {
            progressBarTimer.Start();
        }

        private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            int progressBarStatus = progressBar1.Value;
            if (progressBarStatus == 100)
            {
                progressBarTimer.Stop();
                Hide();
                Thread.Sleep(800);
                LoginScreen LoginScreen = new LoginScreen();
                LoginScreen.Show();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
