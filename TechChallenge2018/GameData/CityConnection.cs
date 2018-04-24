namespace TechChallenge2018.GameData
{
    using TechChallenge2018.GameData.Enums;

    public class CityConnection
    {
        public CityName City1 { get; set; }
        public CityName City2 { get; set; }
        public TrainColor TrainColor { get; set; }
        public int Length { get; set; }

        public CityConnection(CityName city1, CityName city2, TrainColor trainColor, int length)
        {
            City1 = city1;
            City2 = city2;
            TrainColor = trainColor;
            Length = length;
        }
    }
}
