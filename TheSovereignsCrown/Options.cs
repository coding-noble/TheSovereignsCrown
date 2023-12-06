namespace TheSovereignsCrown
{
    public partial class Options : Form
    {
        private Form OpenedFrom { get; set; }
        public Options(Form form)
        {
            InitializeComponent();
            OpenedFrom = form;
        }

        private void MapBTN_Click(object sender, EventArgs e)
        {
            Map map = new Map();
            map.Show();
            this.Close();
        }

        private void Options_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void CloseBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EndGameBTN_Click(object sender, EventArgs e)
        {
            Program.mainMenu.Close();
        }
    }
}
