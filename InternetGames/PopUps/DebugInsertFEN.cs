using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InternetGames.PopUps
{
    public partial class DebugInsertFEN : Form
    {
        public DebugInsertFEN()
        {
            InitializeComponent();
        }

        private void BT_ConfirmFEN_Click(object sender, EventArgs e)
        {
            //set FEN in main scene
            //close form
        }

        private void BT_CancelFEN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
