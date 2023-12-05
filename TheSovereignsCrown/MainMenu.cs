namespace TheSovereignsCrown
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void quitGameBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGameBTN_Click(object sender, EventArgs e)
        {
            CharacterCreation characterCreationPage = new CharacterCreation();
            characterCreationPage.Show();
            this.Hide();
        }
    }
}
