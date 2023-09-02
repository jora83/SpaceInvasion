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
    public partial class InformationsForm : Form
    {
        private string objectiveTextPath;
        private string controlsTextPath;

        public InformationsForm()
        {
            InitializeComponent();
            LoadTextFiles();
        }

        private void LoadTextFiles()
        {
            objectiveTextPath = Path.Combine(Application.StartupPath, Constants.ObjectiveFileName);
            controlsTextPath = Path.Combine(Application.StartupPath, Constants.ControlsFileName);
            string objectiveText = File.ReadAllText(objectiveTextPath);
            string controlsText = File.ReadAllText(controlsTextPath);

            objectiveRichTextBox.Text = objectiveText;
            controlsRichTextBox.Text = controlsText;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new();
            this.Hide();
            mainForm.Show();
        }
    }
}
