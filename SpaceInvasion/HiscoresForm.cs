using SpaceInvasion.Scripts;
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
    public partial class HiscoresForm : Form
    {
        public List<User> Users = new List<User>();

        public HiscoresForm()
        {
            Users = GetUsers();
            InitializeComponent();
        }

        private List<User> GetUsers()
        {
            var list = new List<User>();
            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
