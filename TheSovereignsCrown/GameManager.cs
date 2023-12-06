namespace TheSovereignsCrown
{
    public static class GameManager
    {
        public static NPC KingAlaricBlackthorne = new NPC("King Alaric Blackthorne", GenderEnums.Male, StatusEnums.Nobility);

        public static NobilityNPC ArabellaRavenscroft = new NobilityNPC("Arabella Ravenscroft", GenderEnums.Female);
        public static NobilityNPC EvelynAshbourne = new NobilityNPC("Evelyn Ashbourne", GenderEnums.Female);
        public static NobilityNPC ElaraWhitmore = new NobilityNPC("Elara Whitmore", GenderEnums.Female);
        public static NobilityNPC CedricHawthorne = new NobilityNPC("Cedric Hawthorne", GenderEnums.Male);
        public static NobilityNPC EdmundBlackwell = new NobilityNPC("Edmund Blackwell", GenderEnums.Male);
        public static NobilityNPC WilliamMontague = new NobilityNPC("William Montague", GenderEnums.Male);
        public static NobilityNPC HarrisonRedcliffe = new NobilityNPC("Harrison Redcliffe", GenderEnums.Male);

        public static NPC KingsAdvisor = new NPC("Lord Aric Davenport", GenderEnums.Male, StatusEnums.None);
        public static NPC RoyalGuardCaptain = new NPC("Sir Roland Ashcroft", GenderEnums.Male, StatusEnums.None);
        public static NPC CastleServant = new NPC("Eliza Bennett", GenderEnums.Female, StatusEnums.None);
        public static NPC CourtJester = new NPC("Merrick Thorne", GenderEnums.Male, StatusEnums.None);
        public static NPC RoyalCook = new NPC("Chef Isabella Renard", GenderEnums.Female, StatusEnums.None);
        public static NPC TravellingBard = new NPC("Cedric Nightingale", GenderEnums.Male, StatusEnums.None);

        public static CommonerNPC Innkeeper = new CommonerNPC("Bartholomew Wells", GenderEnums.Male);
        public static CommonerNPC Blacksmith = new CommonerNPC("Alistair Forge", GenderEnums.Male);
        public static CommonerNPC TownCrier = new CommonerNPC("Beatrice Carter", GenderEnums.Female);
        public static CommonerNPC LocalMerchant = new CommonerNPC("Lydia Summers", GenderEnums.Female);
        public static CommonerNPC TavernOwner = new CommonerNPC("Roderick Oakley", GenderEnums.Male);
        public static CommonerNPC FarmOwner = new CommonerNPC("Duncan Plow", GenderEnums.Male);
        public static CommonerNPC FruitVendor = new CommonerNPC("Anna Appleby", GenderEnums.Female);
        public static CommonerNPC LivestockHerder = new CommonerNPC("Marcus Shepherd", GenderEnums.Male);
        public static CommonerNPC HarvestWorker = new CommonerNPC("Sara Fields", GenderEnums.Female);
        public static CommonerNPC Beekeeper = new CommonerNPC("Edward Honeywell", GenderEnums.Male);
        public static CommonerNPC Woodsman = new CommonerNPC("Finnegan Timbermen", GenderEnums.Male);
        public static CommonerNPC Hermit = new CommonerNPC("Astrid Willow", GenderEnums.Female);
        public static CommonerNPC ForestHarvester = new CommonerNPC("Thalia Greenleaf", GenderEnums.Female);
        public static CommonerNPC MysteriousStranger = new CommonerNPC("Rowna Shadowvale", GenderEnums.Female);
        public static CommonerNPC Fisherwoman = new CommonerNPC("Marina Waters", GenderEnums.Female);
        public static CommonerNPC Boatman = new CommonerNPC("Tobias Riverstone", GenderEnums.Male);
        public static CommonerNPC LocalPainter = new CommonerNPC("Emilia Banks", GenderEnums.Female);
        public static CommonerNPC RetiredSailor = new CommonerNPC("Captain Jonathan Storm", GenderEnums.Male);


        public static Location ThroneRoom = new Location("Throne Room", "");
        public static Location RoyalChambers = new Location("Royal Chambers", "");
        public static Location CouncilRoom = new Location("Council Room", "");
        public static Location TrainingGrounds = new Location("Training Grounds", "");
        public static Location Gardens = new Location("Gardens", "");
        public static Location Stables = new Location("Stables", "");
        public static Location MarketPlace = new Location("Market Place", "");
        public static Location ResidentialDistrict = new Location("Residential District", "");
        public static Location FarmLands = new Location("Farm Lands", "");
        public static Location Woods = new Location("Woods", "");
        public static Location Riverbank = new Location("Riverbank", "");
    }
}
