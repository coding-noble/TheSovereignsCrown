namespace TheSovereignsCrown
{
    public partial class Map : Form
    {
        public Map()
        {
            InitializeComponent();
        }

        private void ThroneRoomBTN_Click(object sender, EventArgs e)
        {
            RoomDisplay ThroneRoomDisplay = new RoomDisplay(GameManager.ThroneRoom);
            ThroneRoomDisplay.Show();
            this.Close();
        }
    }
}
