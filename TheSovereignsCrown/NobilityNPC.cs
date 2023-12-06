namespace TheSovereignsCrown
{
    public class NobilityNPC : NPC
    {
        public string Title { get; set; }
        public NobilityNPC(string name, GenderEnums gender) : base(name, gender, StatusEnums.Nobility)
        {
            Title = gender == GenderEnums.Male ? "Lord" : "Lady";
        }
    }
}
