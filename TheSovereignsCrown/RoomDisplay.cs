namespace TheSovereignsCrown
{
    public partial class RoomDisplay : Form
    {
        private Location LocationObj;
        public RoomDisplay(Location location)
        {
            InitializeComponent();
            LocationObj = location;
        }

        private void RoomDisplay_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Options optionsMenu = new Options(this);
                optionsMenu.Show();
            }
        }

        private void RoomDisplay_Load(object sender, EventArgs e)
        {
            LocationDisplayLBL.Text = LocationObj.Name;
        }
    }
}
