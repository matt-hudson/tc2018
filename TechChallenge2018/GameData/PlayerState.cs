namespace TechChallenge2018.GameData
{
    using System.Collections.Generic;
    using TechChallenge2018.GameData.Enums;

    public class PlayerState
    {
        public List<CityConnection> ClaimedConnections { get; set; }
        public int TrainsInHand { get; set; }
        public List<CardColor> CardsInHand { get; set; }
        public List<Route> RoutesInHand { get; set; }
    }
}
