using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternetGames.Util;

namespace InternetGames
{
    public partial class StartupScreen : Form
    {
        public StartupScreen()
        {
            InitializeComponent();
        }

        private void BT_StartupHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(BT_StartupHelp, Paths.Absolute(".\\Resources\\chkr.chm"));
        }

        private void BT_StartupQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BT_StartupPlay_Click(object sender, EventArgs e)
        {
            LB_InternetPrompt.Text = String.Empty;
#if DEBUG
            if(BT_StartupPlay.Text == "Try Again")
            {
                this.Hide();
                CheckersWindow wind = new CheckersWindow();
                wind.ShowDialog();
                this.Close();
            }
#endif
            if (Internet.Connected())
            {
                LB_StartupPrivacy.Text = "Connecting to game servers...";
                BT_StartupPlay.Visible = false;
                //TODO: connect to game servers
                this.Hide();
                CheckersWindow wind = new CheckersWindow();
                wind.ShowDialog();
                this.Close();

            }
            else
            {
                LB_StartupPrivacy.Text = "No internet connection found. Please connect to the internet and try again.";
                BT_StartupPlay.Text = "Try Again";
            }
        }
    }
}
