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
            //GameForm gameForm = new GameForm();
            //this.Hide();
            //gameForm.Show();    

            EnterUserForm enterUserForm = new EnterUserForm();
            this.Hide();
            enterUserForm.Show();
        }

        private void hiscoresButton_Click(object sender, EventArgs e)
        {
            HiscoresForm hiscoresForm = new HiscoresForm();
            this.Hide();
            hiscoresForm.Show();
        }

        private void rulesButton_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        
    }
}