using SpaceInvasion.Scripts;

namespace SpaceInvasion
{
    public partial class MainForm : Form
    {
        HighscoreSystem HighscoreSystem = new HighscoreSystem();
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            EnterUserForm enterUserForm = new EnterUserForm();
            this.Hide();
            enterUserForm.Show();
        }

        private void hiscoresButton_Click(object sender, EventArgs e)
        {
            HighScoresForm hiscoresForm = new HighScoresForm();
            this.Hide();
            hiscoresForm.Show();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {
            InformationsForm informationsForm = new InformationsForm();
            this.Hide();
            informationsForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}