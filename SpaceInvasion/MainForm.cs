namespace SpaceInvasion
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }



        private void startButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.Show();    
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