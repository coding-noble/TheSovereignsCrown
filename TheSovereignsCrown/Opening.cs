using System.Text.Json;

namespace TheSovereignsCrown
{
    public partial class Opening : Form
    {

        public Opening()
        {
            InitializeComponent();
            GetBackstory();
        }

        private void GetBackstory()
        {
            string jsonFileName = "backstories.json";
            string directoryPath = AppDomain.CurrentDomain.BaseDirectory;
            string relativeFolderPath = @"..\..\Narratives\";

            string jsonFilePath = Path.GetFullPath(Path.Combine(directoryPath, relativeFolderPath, jsonFileName));

            string jsonDataString = File.ReadAllText(jsonFilePath);

            using JsonDocument doc = JsonDocument.Parse(jsonDataString);

            MessageBox.Show($"{Program.loadedUser.Background.Replace(' ', '-').ToLower()}");

            JsonElement root = doc.RootElement;
            JsonElement testArray = root.GetProperty("backgrounds").GetProperty(Program.loadedUser.Class.Replace(' ', '-').ToLower()).GetProperty(Program.loadedUser.Background.Replace(' ', '-').ToLower());

            foreach (JsonProperty property in testArray.EnumerateObject())
            {
                MessageBox.Show($"{property.Value.GetString()}");
            }
        }
    }
}
