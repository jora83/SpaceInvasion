namespace SpaceInvasion
{
    public partial class MainForm : Form
    {
        public GameForm gameForm = new GameForm();
        public MainForm()
        {
            InitializeComponent();
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            gameForm.Show();
        }

        private void hiscoresButton_Click_1(object sender, EventArgs e)
        {

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