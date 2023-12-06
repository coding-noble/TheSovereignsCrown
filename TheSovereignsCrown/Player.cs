using TheSovereignsCrown;

public class Player
{
    public string Name { get; set; }
    public string Class { get; set; }
    public string Background { get; set; }
    public GenderEnums Gender { get; set; }
    public StatusEnums Status { get; set; }
    public Location CurrentLocation { get; set; }

    public Player(string name, GenderEnums gender, string playerClass, string background)
    {
        Name = name;
        Class = playerClass;
        Gender = gender;
        Background = background;
        switch(Class)
        {
            case "Courtly scion":
                Status = StatusEnums.Nobility;
                break;
            case "Humble Beginnings":
                Status = StatusEnums.Commoner;
                break;
            default:
                Status = StatusEnums.None;
                break;
        }
        CurrentLocation = StartingLocation();
    }

    private Location StartingLocation()
    {
        if (this.Status == StatusEnums.Nobility)
        {
            return GameManager.CouncilRoom;
        } else
        {
            return GameManager.MarketPlace;
        }
    }

    // Methods
    public void Move()
    {
    }

}
