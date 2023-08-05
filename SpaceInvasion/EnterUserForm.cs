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
    public partial class EnterUserForm : Form
    {
        public static string username;
        public EnterUserForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            username = userTextBox.Text;
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.Show();
        }
    }
}
