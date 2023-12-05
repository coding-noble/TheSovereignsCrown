public class Player
{
    public string Name { get; set; }
    public string Class { get; set; }
    public string Background { get; set; }
    public GenderEnums Gender { get; set; }
    public FactionEnums Faction { get; set; }

    public Player(string name, GenderEnums gender, string playerClass, string background, FactionEnums faction = FactionEnums.None)
    {
        Name = name;
        Class = playerClass;
        Gender = gender;
        Background = background;
        Faction = faction;
    }

    // Methods
    public void Move()
    {
    }

}
