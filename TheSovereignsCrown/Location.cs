namespace TheSovereignsCrown
{
    public class Location
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<NPC> NPCs { get; set; }

        public Location(string name, string description, List<NPC>? residents = null)
        {
            Name = name;
            Description = description;
            NPCs = residents ?? new List<NPC>();
        }
    }
}
