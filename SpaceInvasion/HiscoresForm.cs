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
namespace SpaceInvasion
{
    public partial class HiscoresForm : Form
    {
        HighscoreSystem HighscoreSystem = new HighscoreSystem();
        List<KeyValuePair<string, int>> highscores = new List<KeyValuePair<string, int>>();
        DataTable dataTable = new DataTable();

        public HiscoresForm()
        {
            InitializeComponent();
            HighscoreSystem.LoadHighscores();
            highscores = HighscoreSystem.GetHighscores();
            //ShowHighscores();
            ConvertToDataTable();
        }

        public void ConvertToDataTable()
        {
            dataTable.Columns.Clear();
            dataTable.Columns.Add("Place", typeof(int));
            dataTable.Columns.Add("Username", typeof(string));
            dataTable.Columns.Add("Score", typeof(int));

            int place = 1;
            foreach(var kvp in highscores)
            { 
                dataTable.Rows.Add(place, kvp.Key, kvp.Value);
                place++;
            }

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView.DataSource = dataTable;
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
