using static TheSovereignsCrown.Utilities;
using System.Text.Json;

namespace TheSovereignsCrown
{
    public partial class Opening : Form
    {

        private int currentIndex = 0;
        private List<string> storySnippets = new List<string>();

        public Opening()
        {
            InitializeComponent();
            GetBackstory();
        }

        private void GetBackstory()
        {
            JsonElement openingStory = NarrativesJsonRoot
                .GetProperty("openings")
                .GetProperty(JsonPropertyFormatter(Program.loadedUser.Class))
                .GetProperty(JsonPropertyFormatter(Program.loadedUser.Background));

            foreach (JsonProperty property in openingStory.EnumerateObject())
            {
                storySnippets.Add(property.Value.ToString());
            }

            if (storySnippets.Count > 0)
            {
                DescriptionBox.Text = storySnippets[currentIndex];
            }
        }

        private void Opening_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                currentIndex++;
                if (currentIndex < storySnippets.Count)
                {
                    DescriptionBox.Text = storySnippets[currentIndex];
                }
                else
                {
                    MessageBox.Show("No More. Only testing past this point");
                    RoomDisplay roomDisplay = new RoomDisplay(Program.loadedUser.CurrentLocation);
                    roomDisplay.Show();
                    this.Close();
                }
            }
            
        }
    }
}
