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
using System.Data;
using System.Diagnostics;

namespace SpaceInvasion
{
    public partial class HighScoresForm : Form
    {
        HighscoreSystem HighscoreSystem = new HighscoreSystem();
        List<KeyValuePair<string, int>> highscores = new List<KeyValuePair<string, int>>();
        DataTable dataTable = new DataTable();

        public HighScoresForm()
        {
            InitializeComponent();
            HighscoreSystem.LoadHighscores();
            highscores = HighscoreSystem.GetHighscores();
            ConvertToDataTable();
            Debug.WriteLine(calculate(dataGridView.Rows[0]));
            Debug.WriteLine(calculate(dataGridView.Rows[1]));
            Debug.WriteLine(calculate(dataGridView.Rows[2]));
            Debug.WriteLine(calculate(dataGridView.Rows[3]));
        }
        int calculate(DataGridViewRow row)
        {
            int result = 0;
            foreach (DataGridViewCell cell in row.Cells)
            {
                result = cell.Size.Width;
            }
            return result;
        }
        public void ConvertToDataTable()
        {
            dataTable.Columns.Clear();
            dataTable.Columns.Add("Place", typeof(int));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Score", typeof(int));

            int place = 1;
            foreach (var kvp in highscores)
            {
                dataTable.Rows.Add(place, kvp.Key, kvp.Value);
                place++;
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.DataSource = dataTable;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            this.Hide();
            mainForm.Show();
        }

    }
}
