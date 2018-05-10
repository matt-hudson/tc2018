namespace TechChallenge2018
{
    using System;
    using System.Collections.Generic;
    using TechChallenge2018.GameData;
    using TechChallenge2018.GameData.Enums;
    using TechChallenge2018.GameData.Util;
    using TechChallenge2018.Players;

    public class GameEngine
    {
        private Dictionary<PlayerBase, PlayerState> _players { get; set; }
        private List<Route> _routesDeck { get; set; }
        public void Start()
        {
            SetupRoutesDeck();
        }

        private void SetupRoutesDeck()
        {
            _routesDeck = DataRepository.Routes;
            _routesDeck.Shuffle();
        }
    }
}
