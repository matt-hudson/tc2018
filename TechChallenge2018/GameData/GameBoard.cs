namespace TechChallenge2018.GameData
{
    using System.Collections.Generic;
    using TechChallenge2018.GameData.Enums;

    public class GameBoard
    {
        private List<CityConnection> _cityConnections = new List<CityConnection>();

        public GameBoard()
        {
            InitializeCityConnections();
        }

        private void InitializeCityConnections()
        {
            #region Atlanta

            _cityConnections.Add(new CityConnection(CityName.Atlanta, CityName.Nashville, TrainColor.Any, 1));
            _cityConnections.Add(new CityConnection(CityName.Atlanta, CityName.Raleigh, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Atlanta, CityName.Raleigh, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Atlanta, CityName.Charleston, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Atlanta, CityName.Miami, TrainColor.Blue, 5));
            _cityConnections.Add(new CityConnection(CityName.Atlanta, CityName.NewOrleans, TrainColor.Yellow, 4));
            _cityConnections.Add(new CityConnection(CityName.Atlanta, CityName.NewOrleans, TrainColor.Orange, 4));

            #endregion  Atlanta

            #region Boston

            _cityConnections.Add(new CityConnection(CityName.Boston, CityName.Montreal, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Boston, CityName.Montreal, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Boston, CityName.NewYork, TrainColor.Yellow, 2));
            _cityConnections.Add(new CityConnection(CityName.Boston, CityName.NewYork, TrainColor.Red, 2));

            #endregion Boston

            #region Calgary

            _cityConnections.Add(new CityConnection(CityName.Calgary, CityName.Winnipeg, TrainColor.White, 6));
            _cityConnections.Add(new CityConnection(CityName.Calgary, CityName.Helena, TrainColor.Any, 4));
            _cityConnections.Add(new CityConnection(CityName.Calgary, CityName.Seattle, TrainColor.Any, 4));
            _cityConnections.Add(new CityConnection(CityName.Calgary, CityName.Vancouver, TrainColor.Any, 3));

            #endregion Calgary

            #region Charleston

            _cityConnections.Add(new CityConnection(CityName.Charleston, CityName.Raleigh, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Charleston, CityName.Miami, TrainColor.Pink, 4));

            #endregion Charleston

            #region Chicago

            _cityConnections.Add(new CityConnection(CityName.Chicago, CityName.SaintLouis, TrainColor.Green, 2));
            _cityConnections.Add(new CityConnection(CityName.Chicago, CityName.SaintLouis, TrainColor.White, 2));
            _cityConnections.Add(new CityConnection(CityName.Chicago, CityName.Pittsburgh, TrainColor.Black, 3));
            _cityConnections.Add(new CityConnection(CityName.Chicago, CityName.Pittsburgh, TrainColor.Orange, 3));
            _cityConnections.Add(new CityConnection(CityName.Chicago, CityName.Toronto, TrainColor.White, 4));
            _cityConnections.Add(new CityConnection(CityName.Chicago, CityName.Duluth, TrainColor.Red, 3));
            _cityConnections.Add(new CityConnection(CityName.Chicago, CityName.Omaha, TrainColor.Blue, 4));

            #endregion Chicago

            #region Dallas

            _cityConnections.Add(new CityConnection(CityName.Dallas, CityName.OklahomaCity, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Dallas, CityName.OklahomaCity, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Dallas, CityName.LittleRock, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Dallas, CityName.Houston, TrainColor.Any, 1));
            _cityConnections.Add(new CityConnection(CityName.Dallas, CityName.Houston, TrainColor.Any, 1));
            _cityConnections.Add(new CityConnection(CityName.Dallas, CityName.ElPaso, TrainColor.Red, 4));

            #endregion Dallas

            #region Denver

            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.Helena, TrainColor.Green, 4));
            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.Omaha, TrainColor.Pink, 4));
            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.KansasCity, TrainColor.Black, 4));
            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.KansasCity, TrainColor.Orange, 4));
            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.OklahomaCity, TrainColor.Red, 4));
            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.SantaFe, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.Phoenix, TrainColor.White, 5));
            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.SaltLakeCity, TrainColor.Red, 3));
            _cityConnections.Add(new CityConnection(CityName.Denver, CityName.SaltLakeCity, TrainColor.Yellow, 3));

            #endregion Denver

            #region Duluth

            _cityConnections.Add(new CityConnection(CityName.Duluth, CityName.Winnipeg, TrainColor.Black, 4));
            _cityConnections.Add(new CityConnection(CityName.Duluth, CityName.SaultStMarie, TrainColor.Any, 3));
            _cityConnections.Add(new CityConnection(CityName.Duluth, CityName.Toronto, TrainColor.Pink, 6));
            _cityConnections.Add(new CityConnection(CityName.Duluth, CityName.Omaha, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Duluth, CityName.Omaha, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Duluth, CityName.Helena, TrainColor.Orange, 6));

            #endregion Duluth

            #region El Paso

            _cityConnections.Add(new CityConnection(CityName.ElPaso, CityName.SantaFe, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.ElPaso, CityName.OklahomaCity, TrainColor.Yellow, 5));
            _cityConnections.Add(new CityConnection(CityName.ElPaso, CityName.Houston, TrainColor.Green, 6));
            _cityConnections.Add(new CityConnection(CityName.ElPaso, CityName.LosAngeles, TrainColor.Black, 6));
            _cityConnections.Add(new CityConnection(CityName.ElPaso, CityName.Phoenix, TrainColor.Any, 3));

            #endregion El Paso

            #region Helena

            _cityConnections.Add(new CityConnection(CityName.Helena, CityName.Winnipeg, TrainColor.Blue, 4));
            _cityConnections.Add(new CityConnection(CityName.Helena, CityName.Omaha, TrainColor.Red, 5));
            _cityConnections.Add(new CityConnection(CityName.Helena, CityName.SaltLakeCity, TrainColor.Pink, 3));
            _cityConnections.Add(new CityConnection(CityName.Helena, CityName.Seattle, TrainColor.Yellow, 6));

            #endregion Helena

            #region Houston

            _cityConnections.Add(new CityConnection(CityName.Houston, CityName.NewOrleans, TrainColor.Any, 2));

            #endregion Houston

            #region Kansas City

            _cityConnections.Add(new CityConnection(CityName.KansasCity, CityName.Omaha, TrainColor.Any, 1));
            _cityConnections.Add(new CityConnection(CityName.KansasCity, CityName.Omaha, TrainColor.Any, 1));
            _cityConnections.Add(new CityConnection(CityName.KansasCity, CityName.SaintLouis, TrainColor.Blue, 2));
            _cityConnections.Add(new CityConnection(CityName.KansasCity, CityName.SaintLouis, TrainColor.Pink, 2));
            _cityConnections.Add(new CityConnection(CityName.KansasCity, CityName.OklahomaCity, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.KansasCity, CityName.OklahomaCity, TrainColor.Any, 2));

            #endregion Kansas City

            #region Las Vegas

            _cityConnections.Add(new CityConnection(CityName.LasVegas, CityName.LosAngeles, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.LasVegas, CityName.SaltLakeCity, TrainColor.Orange, 3));

            #endregion Las Vegas

            #region Little Rock

            _cityConnections.Add(new CityConnection(CityName.LittleRock, CityName.Nashville, TrainColor.White, 3));
            _cityConnections.Add(new CityConnection(CityName.LittleRock, CityName.NewOrleans, TrainColor.Green, 3));
            _cityConnections.Add(new CityConnection(CityName.LittleRock, CityName.OklahomaCity, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.LittleRock, CityName.SaintLouis, TrainColor.Any, 2));

            #endregion Little Rock

            #region Los Angeles

            _cityConnections.Add(new CityConnection(CityName.LosAngeles, CityName.Phoenix, TrainColor.Any, 3));
            _cityConnections.Add(new CityConnection(CityName.LosAngeles, CityName.SanFrancisco, TrainColor.Pink, 3));
            _cityConnections.Add(new CityConnection(CityName.LosAngeles, CityName.SanFrancisco, TrainColor.Yellow, 3));

            #endregion Los Angeles
            
            #region Miami

            _cityConnections.Add(new CityConnection(CityName.Miami, CityName.NewOrleans, TrainColor.Red, 6));

            #endregion Miami

            #region Montreal

            _cityConnections.Add(new CityConnection(CityName.Montreal, CityName.NewYork, TrainColor.Blue, 3));
            _cityConnections.Add(new CityConnection(CityName.Montreal, CityName.Toronto, TrainColor.Any, 3));
            _cityConnections.Add(new CityConnection(CityName.Montreal, CityName.SaultStMarie, TrainColor.Black, 5));

            #endregion Montreal

            #region Nashville

            _cityConnections.Add(new CityConnection(CityName.Nashville, CityName.Pittsburgh, TrainColor.Yellow, 4));
            _cityConnections.Add(new CityConnection(CityName.Nashville, CityName.Raleigh, TrainColor.Black, 3));
            _cityConnections.Add(new CityConnection(CityName.Nashville, CityName.SaintLouis, TrainColor.Any, 2));

            #endregion Nashville

            #region New Orleans

            // None

            #endregion New Orleans

            #region New York

            _cityConnections.Add(new CityConnection(CityName.NewYork, CityName.Washington, TrainColor.Orange, 2));
            _cityConnections.Add(new CityConnection(CityName.NewYork, CityName.Washington, TrainColor.Black, 2));
            _cityConnections.Add(new CityConnection(CityName.NewYork, CityName.Pittsburgh, TrainColor.White, 2));
            _cityConnections.Add(new CityConnection(CityName.NewYork, CityName.Pittsburgh, TrainColor.Green, 2));

            #endregion New York

            #region Oklahoma City

            _cityConnections.Add(new CityConnection(CityName.OklahomaCity, CityName.SantaFe, TrainColor.Blue, 3));

            #endregion Oklahoma City

            #region Omaha

            // None

            #endregion Omaha

            #region Phoenix

            _cityConnections.Add(new CityConnection(CityName.Phoenix, CityName.SantaFe, TrainColor.Any, 3));

            #endregion Phoenix

            #region Pittsburgh

            _cityConnections.Add(new CityConnection(CityName.Pittsburgh, CityName.Toronto, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Pittsburgh, CityName.Washington, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Pittsburgh, CityName.Raleigh, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Pittsburgh, CityName.SaintLouis, TrainColor.Green, 5));

            #endregion Pittsburgh

            #region Portland

            _cityConnections.Add(new CityConnection(CityName.Portland, CityName.Seattle, TrainColor.Any, 1));
            _cityConnections.Add(new CityConnection(CityName.Portland, CityName.Seattle, TrainColor.Any, 1));
            _cityConnections.Add(new CityConnection(CityName.Portland, CityName.SaltLakeCity, TrainColor.Blue, 6));
            _cityConnections.Add(new CityConnection(CityName.Portland, CityName.SanFrancisco, TrainColor.Pink, 5));
            _cityConnections.Add(new CityConnection(CityName.Portland, CityName.SanFrancisco, TrainColor.Green, 5));

            #endregion Portland

            #region Raleigh

            _cityConnections.Add(new CityConnection(CityName.Raleigh, CityName.Winnipeg, TrainColor.Any, 2));
            _cityConnections.Add(new CityConnection(CityName.Raleigh, CityName.Winnipeg, TrainColor.Any, 2));

            #endregion Raleigh

            #region Salt Lake City

            _cityConnections.Add(new CityConnection(CityName.SaltLakeCity, CityName.SanFrancisco, TrainColor.White, 5));
            _cityConnections.Add(new CityConnection(CityName.SaltLakeCity, CityName.SanFrancisco, TrainColor.Orange, 5));

            #endregion Salt Lake City

            #region San Francisco

            // None

            #endregion San Francisco

            #region Santa Fe

            // None

            #endregion Santa Fe

            #region Sault St Marie

            _cityConnections.Add(new CityConnection(CityName.SaultStMarie, CityName.Winnipeg, TrainColor.Any, 6));
            _cityConnections.Add(new CityConnection(CityName.SaultStMarie, CityName.Toronto, TrainColor.Any, 2));

            #endregion Sault St Marie

            #region Seattle

            _cityConnections.Add(new CityConnection(CityName.Seattle, CityName.Vancouver, TrainColor.Any, 1));
            _cityConnections.Add(new CityConnection(CityName.Seattle, CityName.Vancouver, TrainColor.Any, 1));

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
    }
}
