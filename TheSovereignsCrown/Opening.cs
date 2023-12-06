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
            string jsonFileName = "narratives.json";
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;

            string jsonFilePath = Path.GetFullPath(Path.Combine(directoryPath, jsonFileName));

            string jsonDataString = File.ReadAllText(jsonFilePath);

            using JsonDocument doc = JsonDocument.Parse(jsonDataString);

            JsonElement root = doc.RootElement;
            JsonElement openingStory = root
                .GetProperty("narratives")
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
                    MessageBox.Show("No More");
                    Program.mainMenu.Close();
                }
            }
            
        }
    }
}
