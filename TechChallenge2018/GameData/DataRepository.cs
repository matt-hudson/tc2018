namespace TechChallenge2018.GameData
{
    using System.Collections.Generic;
    using System.Linq;
    using TechChallenge2018.GameData.Enums;

    public static class DataRepository
    {
        public static List<CityConnection> CityConnections { get; }
        public static List<Route> Routes { get; }

        static DataRepository()
        {
            CityConnections = new List<CityConnection>();
            InitializeCityConnections();

            Routes = new List<Route>();
            InitializeRoutes();
        }

        public static List<CityConnection> GetConnectionsForCity(CityName cityName)
        {
            return CityConnections.Where(c => c.City1 == cityName || c.City2 == cityName).ToList();
        }

        private static void InitializeCityConnections()
        {
            #region Atlanta

            CityConnections.Add(new CityConnection(1, CityName.Atlanta, CityName.Nashville, TrainColor.Any, 1));
            CityConnections.Add(new CityConnection(2, CityName.Atlanta, CityName.Raleigh, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(3, CityName.Atlanta, CityName.Raleigh, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(4, CityName.Atlanta, CityName.Charleston, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(5, CityName.Atlanta, CityName.Miami, TrainColor.Blue, 5));
            CityConnections.Add(new CityConnection(6, CityName.Atlanta, CityName.NewOrleans, TrainColor.Yellow, 4));
            CityConnections.Add(new CityConnection(7, CityName.Atlanta, CityName.NewOrleans, TrainColor.Orange, 4));

            #endregion  Atlanta

            #region Boston

            CityConnections.Add(new CityConnection(8, CityName.Boston, CityName.Montreal, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(9, CityName.Boston, CityName.Montreal, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(10, CityName.Boston, CityName.NewYork, TrainColor.Yellow, 2));
            CityConnections.Add(new CityConnection(11, CityName.Boston, CityName.NewYork, TrainColor.Red, 2));

            #endregion Boston

            #region Calgary

            CityConnections.Add(new CityConnection(12, CityName.Calgary, CityName.Winnipeg, TrainColor.White, 6));
            CityConnections.Add(new CityConnection(13, CityName.Calgary, CityName.Helena, TrainColor.Any, 4));
            CityConnections.Add(new CityConnection(14, CityName.Calgary, CityName.Seattle, TrainColor.Any, 4));
            CityConnections.Add(new CityConnection(15, CityName.Calgary, CityName.Vancouver, TrainColor.Any, 3));

            #endregion Calgary

            #region Charleston

            CityConnections.Add(new CityConnection(16, CityName.Charleston, CityName.Raleigh, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(17, CityName.Charleston, CityName.Miami, TrainColor.Pink, 4));

            #endregion Charleston

            #region Chicago

            CityConnections.Add(new CityConnection(18, CityName.Chicago, CityName.SaintLouis, TrainColor.Green, 2));
            CityConnections.Add(new CityConnection(19, CityName.Chicago, CityName.SaintLouis, TrainColor.White, 2));
            CityConnections.Add(new CityConnection(20, CityName.Chicago, CityName.Pittsburgh, TrainColor.Black, 3));
            CityConnections.Add(new CityConnection(21, CityName.Chicago, CityName.Pittsburgh, TrainColor.Orange, 3));
            CityConnections.Add(new CityConnection(22, CityName.Chicago, CityName.Toronto, TrainColor.White, 4));
            CityConnections.Add(new CityConnection(23, CityName.Chicago, CityName.Duluth, TrainColor.Red, 3));
            CityConnections.Add(new CityConnection(24, CityName.Chicago, CityName.Omaha, TrainColor.Blue, 4));

            #endregion Chicago

            #region Dallas

            CityConnections.Add(new CityConnection(25, CityName.Dallas, CityName.OklahomaCity, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(26, CityName.Dallas, CityName.OklahomaCity, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(27, CityName.Dallas, CityName.LittleRock, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(28, CityName.Dallas, CityName.Houston, TrainColor.Any, 1));
            CityConnections.Add(new CityConnection(29, CityName.Dallas, CityName.Houston, TrainColor.Any, 1));
            CityConnections.Add(new CityConnection(30, CityName.Dallas, CityName.ElPaso, TrainColor.Red, 4));

            #endregion Dallas

            #region Denver

            CityConnections.Add(new CityConnection(31, CityName.Denver, CityName.Helena, TrainColor.Green, 4));
            CityConnections.Add(new CityConnection(32, CityName.Denver, CityName.Omaha, TrainColor.Pink, 4));
            CityConnections.Add(new CityConnection(33, CityName.Denver, CityName.KansasCity, TrainColor.Black, 4));
            CityConnections.Add(new CityConnection(34, CityName.Denver, CityName.KansasCity, TrainColor.Orange, 4));
            CityConnections.Add(new CityConnection(35, CityName.Denver, CityName.OklahomaCity, TrainColor.Red, 4));
            CityConnections.Add(new CityConnection(36, CityName.Denver, CityName.SantaFe, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(37, CityName.Denver, CityName.Phoenix, TrainColor.White, 5));
            CityConnections.Add(new CityConnection(38, CityName.Denver, CityName.SaltLakeCity, TrainColor.Red, 3));
            CityConnections.Add(new CityConnection(39, CityName.Denver, CityName.SaltLakeCity, TrainColor.Yellow, 3));

            #endregion Denver

            #region Duluth

            CityConnections.Add(new CityConnection(40, CityName.Duluth, CityName.Winnipeg, TrainColor.Black, 4));
            CityConnections.Add(new CityConnection(41, CityName.Duluth, CityName.SaultStMarie, TrainColor.Any, 3));
            CityConnections.Add(new CityConnection(42, CityName.Duluth, CityName.Toronto, TrainColor.Pink, 6));
            CityConnections.Add(new CityConnection(43, CityName.Duluth, CityName.Omaha, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(44, CityName.Duluth, CityName.Omaha, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(45, CityName.Duluth, CityName.Helena, TrainColor.Orange, 6));

            #endregion Duluth

            #region El Paso

            CityConnections.Add(new CityConnection(46, CityName.ElPaso, CityName.SantaFe, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(47, CityName.ElPaso, CityName.OklahomaCity, TrainColor.Yellow, 5));
            CityConnections.Add(new CityConnection(48, CityName.ElPaso, CityName.Houston, TrainColor.Green, 6));
            CityConnections.Add(new CityConnection(49, CityName.ElPaso, CityName.LosAngeles, TrainColor.Black, 6));
            CityConnections.Add(new CityConnection(50, CityName.ElPaso, CityName.Phoenix, TrainColor.Any, 3));

            #endregion El Paso

            #region Helena

            CityConnections.Add(new CityConnection(51, CityName.Helena, CityName.Winnipeg, TrainColor.Blue, 4));
            CityConnections.Add(new CityConnection(52, CityName.Helena, CityName.Omaha, TrainColor.Red, 5));
            CityConnections.Add(new CityConnection(53, CityName.Helena, CityName.SaltLakeCity, TrainColor.Pink, 3));
            CityConnections.Add(new CityConnection(54, CityName.Helena, CityName.Seattle, TrainColor.Yellow, 6));

            #endregion Helena

            #region Houston

            CityConnections.Add(new CityConnection(55, CityName.Houston, CityName.NewOrleans, TrainColor.Any, 2));

            #endregion Houston

            #region Kansas City

            CityConnections.Add(new CityConnection(56, CityName.KansasCity, CityName.Omaha, TrainColor.Any, 1));
            CityConnections.Add(new CityConnection(57, CityName.KansasCity, CityName.Omaha, TrainColor.Any, 1));
            CityConnections.Add(new CityConnection(58, CityName.KansasCity, CityName.SaintLouis, TrainColor.Blue, 2));
            CityConnections.Add(new CityConnection(59, CityName.KansasCity, CityName.SaintLouis, TrainColor.Pink, 2));
            CityConnections.Add(new CityConnection(60, CityName.KansasCity, CityName.OklahomaCity, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(61, CityName.KansasCity, CityName.OklahomaCity, TrainColor.Any, 2));

            #endregion Kansas City

            #region Las Vegas

            CityConnections.Add(new CityConnection(62, CityName.LasVegas, CityName.LosAngeles, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(63, CityName.LasVegas, CityName.SaltLakeCity, TrainColor.Orange, 3));

            #endregion Las Vegas

            #region Little Rock

            CityConnections.Add(new CityConnection(64, CityName.LittleRock, CityName.Nashville, TrainColor.White, 3));
            CityConnections.Add(new CityConnection(65, CityName.LittleRock, CityName.NewOrleans, TrainColor.Green, 3));
            CityConnections.Add(new CityConnection(66, CityName.LittleRock, CityName.OklahomaCity, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(67, CityName.LittleRock, CityName.SaintLouis, TrainColor.Any, 2));

            #endregion Little Rock

            #region Los Angeles

            CityConnections.Add(new CityConnection(68, CityName.LosAngeles, CityName.Phoenix, TrainColor.Any, 3));
            CityConnections.Add(new CityConnection(69, CityName.LosAngeles, CityName.SanFrancisco, TrainColor.Pink, 3));
            CityConnections.Add(new CityConnection(70, CityName.LosAngeles, CityName.SanFrancisco, TrainColor.Yellow, 3));

            #endregion Los Angeles

            #region Miami

            CityConnections.Add(new CityConnection(71, CityName.Miami, CityName.NewOrleans, TrainColor.Red, 6));

            #endregion Miami

            #region Montreal

            CityConnections.Add(new CityConnection(72, CityName.Montreal, CityName.NewYork, TrainColor.Blue, 3));
            CityConnections.Add(new CityConnection(73, CityName.Montreal, CityName.Toronto, TrainColor.Any, 3));
            CityConnections.Add(new CityConnection(74, CityName.Montreal, CityName.SaultStMarie, TrainColor.Black, 5));

            #endregion Montreal

            #region Nashville

            CityConnections.Add(new CityConnection(75, CityName.Nashville, CityName.Pittsburgh, TrainColor.Yellow, 4));
            CityConnections.Add(new CityConnection(76, CityName.Nashville, CityName.Raleigh, TrainColor.Black, 3));
            CityConnections.Add(new CityConnection(77, CityName.Nashville, CityName.SaintLouis, TrainColor.Any, 2));

            #endregion Nashville

            #region New Orleans

            // None

            #endregion New Orleans

            #region New York

            CityConnections.Add(new CityConnection(78, CityName.NewYork, CityName.Washington, TrainColor.Orange, 2));
            CityConnections.Add(new CityConnection(79, CityName.NewYork, CityName.Washington, TrainColor.Black, 2));
            CityConnections.Add(new CityConnection(80, CityName.NewYork, CityName.Pittsburgh, TrainColor.White, 2));
            CityConnections.Add(new CityConnection(81, CityName.NewYork, CityName.Pittsburgh, TrainColor.Green, 2));

            #endregion New York

            #region Oklahoma City

            CityConnections.Add(new CityConnection(82, CityName.OklahomaCity, CityName.SantaFe, TrainColor.Blue, 3));

            #endregion Oklahoma City

            #region Omaha

            // None

            #endregion Omaha

            #region Phoenix

            CityConnections.Add(new CityConnection(83, CityName.Phoenix, CityName.SantaFe, TrainColor.Any, 3));

            #endregion Phoenix

            #region Pittsburgh

            CityConnections.Add(new CityConnection(84, CityName.Pittsburgh, CityName.Toronto, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(85, CityName.Pittsburgh, CityName.Washington, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(86, CityName.Pittsburgh, CityName.Raleigh, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(87, CityName.Pittsburgh, CityName.SaintLouis, TrainColor.Green, 5));

            #endregion Pittsburgh

            #region Portland

            CityConnections.Add(new CityConnection(88, CityName.Portland, CityName.Seattle, TrainColor.Any, 1));
            CityConnections.Add(new CityConnection(89, CityName.Portland, CityName.Seattle, TrainColor.Any, 1));
            CityConnections.Add(new CityConnection(90, CityName.Portland, CityName.SaltLakeCity, TrainColor.Blue, 6));
            CityConnections.Add(new CityConnection(91, CityName.Portland, CityName.SanFrancisco, TrainColor.Pink, 5));
            CityConnections.Add(new CityConnection(92, CityName.Portland, CityName.SanFrancisco, TrainColor.Green, 5));

            #endregion Portland

            #region Raleigh

            CityConnections.Add(new CityConnection(93, CityName.Raleigh, CityName.Winnipeg, TrainColor.Any, 2));
            CityConnections.Add(new CityConnection(94, CityName.Raleigh, CityName.Winnipeg, TrainColor.Any, 2));

            #endregion Raleigh

            #region Salt Lake City

            CityConnections.Add(new CityConnection(95, CityName.SaltLakeCity, CityName.SanFrancisco, TrainColor.White, 5));
            CityConnections.Add(new CityConnection(96, CityName.SaltLakeCity, CityName.SanFrancisco, TrainColor.Orange, 5));

            #endregion Salt Lake City

            #region San Francisco

            // None

            #endregion San Francisco

            #region Santa Fe

            // None

            #endregion Santa Fe

            #region Sault St Marie

            CityConnections.Add(new CityConnection(97, CityName.SaultStMarie, CityName.Winnipeg, TrainColor.Any, 6));
            CityConnections.Add(new CityConnection(98, CityName.SaultStMarie, CityName.Toronto, TrainColor.Any, 2));

            #endregion Sault St Marie

            #region Seattle

            CityConnections.Add(new CityConnection(99, CityName.Seattle, CityName.Vancouver, TrainColor.Any, 1));
            CityConnections.Add(new CityConnection(100, CityName.Seattle, CityName.Vancouver, TrainColor.Any, 1));

            #endregion Seattle

            #region Saint Louis

            // None

            #endregion Saint Louis

            #region Toronto

            // None

            #endregion Toronto

            #region Vancouver

            // None

            #endregion Vancouver

            #region Washington

            // None

            #endregion Washington

            #region Winnipeg

            // None

            #endregion Winnipeg
        }

        private static void InitializeRoutes()
        {
            Routes.Add(new Route(1, CityName.LosAngeles, CityName.NewYork, 21));
            Routes.Add(new Route(2, CityName.Duluth, CityName.Houston, 8));
            Routes.Add(new Route(3, CityName.SaultStMarie, CityName.Nashville, 8));
            Routes.Add(new Route(4, CityName.NewYork, CityName.Atlanta, 6));
            Routes.Add(new Route(5, CityName.Portland, CityName.Nashville, 17));
            Routes.Add(new Route(6, CityName.Vancouver, CityName.Montreal, 20));
            Routes.Add(new Route(7, CityName.Duluth, CityName.ElPaso, 10));
            Routes.Add(new Route(8, CityName.Toronto, CityName.Miami, 10));
            Routes.Add(new Route(9, CityName.Portland, CityName.Phoenix, 11));
            Routes.Add(new Route(10, CityName.Dallas, CityName.NewYork, 11));
            Routes.Add(new Route(11, CityName.Calgary, CityName.SaltLakeCity, 7));
            Routes.Add(new Route(12, CityName.Calgary, CityName.Phoenix, 13));
            Routes.Add(new Route(13, CityName.LosAngeles, CityName.Miami, 20));
            Routes.Add(new Route(14, CityName.Winnipeg, CityName.LittleRock, 11));
            Routes.Add(new Route(15, CityName.SanFrancisco, CityName.Atlanta, 17));
            Routes.Add(new Route(16, CityName.KansasCity, CityName.Houston, 5));
            Routes.Add(new Route(17, CityName.LosAngeles, CityName.Chicago, 16));
            Routes.Add(new Route(18, CityName.Denver, CityName.Pittsburgh, 11));
            Routes.Add(new Route(19, CityName.Chicago, CityName.SantaFe, 9));
            Routes.Add(new Route(20, CityName.Vancouver, CityName.SantaFe, 13));
            Routes.Add(new Route(21, CityName.Boston, CityName.Miami, 12));
            Routes.Add(new Route(22, CityName.Chicago, CityName.NewOrleans, 7));
            Routes.Add(new Route(23, CityName.Montreal, CityName.Atlanta, 9));
            Routes.Add(new Route(24, CityName.Seattle, CityName.NewYork, 22));
            Routes.Add(new Route(25, CityName.Denver, CityName.ElPaso, 4));
            Routes.Add(new Route(26, CityName.Helena, CityName.LosAngeles, 8));
            Routes.Add(new Route(27, CityName.Winnipeg, CityName.Houston, 12));
            Routes.Add(new Route(28, CityName.Montreal, CityName.NewOrleans, 13));
            Routes.Add(new Route(29, CityName.SaultStMarie, CityName.OklahomaCity, 9));
            Routes.Add(new Route(30, CityName.Seattle, CityName.LosAngeles, 9));
        }
    }
}
