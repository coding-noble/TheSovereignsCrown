public class NPC
{
    public string Name { get; set; }
    public GenderEnums Gender { get; set; }
    public FactionEnums Faction { get; set; }

    public NPC(string name, GenderEnums gender, FactionEnums faction)
    {
        Name = name;
        Gender = gender;
        Faction = faction;
    }
}
