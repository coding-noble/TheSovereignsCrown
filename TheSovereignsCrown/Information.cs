namespace TheSovereignsCrown
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            Program.mainMenu.Show();
            this.Close();
        }
    }
}
