namespace TechChallenge2018.GameData
{
    using TechChallenge2018.GameData.Enums;

    public class Route
    {
        public int Id { get; }
        public CityName City1 { get; }
        public CityName City2 { get; }
        public int Points { get; }

        public Route(int id, CityName city1, CityName city2, int points)
        {
            Id = id;
            City1 = city1;
            City2 = city2;
            Points = points;
        }
    }
}
