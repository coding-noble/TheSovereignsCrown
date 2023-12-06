public class NPC
{
    public string Name { get; set; }
    public GenderEnums Gender { get; set; }
    public StatusEnums Faction { get; set; }

    public NPC(string name, GenderEnums gender, StatusEnums faction = StatusEnums.None)
    {
        Name = name;
        Gender = gender;
        Faction = faction;
    }
}
