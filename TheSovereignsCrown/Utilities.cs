using System.Text.Json;

namespace TheSovereignsCrown
{
    public static class Utilities
    {
        public static string JsonPropertyFormatter(string str)
        {
            return str.Replace(' ', '-').ToLower();
        }

        public static void StoryLoader(Label label, JsonElement jsonElement)
        {
            
        }
    }
}
