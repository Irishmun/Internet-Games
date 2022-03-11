using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetGames
{
    public partial class CheckersWindow : Form
    {
        public CheckersWindow()
        {
            InitializeComponent();
#if !DEBUG
            TSMI_Debug.Visible = false;
#endif

            LB_OpponentColor.Parent = PB_CheckersField;
            LB_OpponentColor.Text = "Red";
            LB_YourColor.Parent = PB_CheckersField;
            LB_YourColor.Text = "White";
            pictureBox2.Parent = PB_CheckersField;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
