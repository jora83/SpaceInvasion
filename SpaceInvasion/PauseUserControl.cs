using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceInvasion
{
    public partial class PauseUserControl : UserControl
    {
        private static bool exitButtonClicked;
        public PauseUserControl()
        {
            InitializeComponent();
            //this.BackColor = Color.FromArgb(25, this.BackColor);
        }

        public void exitButton_Click(object sender, EventArgs e)
        {
            exitButtonClicked = true;
        }
    }
}
