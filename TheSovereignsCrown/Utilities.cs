using System.Text.Json;

namespace TheSovereignsCrown
{
    public static class Utilities
    {
        private static string jsonFilePath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "narratives.json"));
        private static string jsonDataString = File.ReadAllText(jsonFilePath);
        public static JsonElement NarrativesJsonRoot = JsonDocument.Parse(jsonDataString).RootElement;

        public static string JsonPropertyFormatter(string str)
        {
            return str.Replace(' ', '-').ToLower();
        }

        public static void OpenOptions(Form form)
        {
            Options options = new Options(form);
            options.Show();
            form.Hide();
        }
    }
}
