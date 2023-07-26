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
        HighscoreSystem HighscoreSystem = new HighscoreSystem();
        List<KeyValuePair<string, int>> highscores = new List<KeyValuePair<string, int>>();

        public HiscoresForm()
        {
            InitializeComponent();
            HighscoreSystem.LoadHighscores();
            highscores = HighscoreSystem.GetHighscores();
            ShowHighscores();
        }

        private void ShowHighscores()
        {
            foreach (var kvp in highscores)
            {
                label1.Text += kvp.Key + ": " + kvp.Value + Environment.NewLine;
            }

            //dataGridView.Rows.Clear();

            //foreach (var cellData in highscores)
            //{
            //    int columnIndex = cellData.Value;
            //    string cellValue = cellData.Key;

            //    // Assuming the row index is the index in the dataList (0-based index)
            //    int rowIndex = dataGridView.Rows.Add();

            //    // Populate the DataGridView cell with the cell value at the specified row and column index
            //    dataGridView.Rows[rowIndex].Cells[columnIndex].Value = cellValue;
            //}
        }
    }
}
