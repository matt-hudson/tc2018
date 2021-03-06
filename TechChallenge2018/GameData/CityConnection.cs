﻿namespace TechChallenge2018.GameData
{
    using TechChallenge2018.GameData.Enums;

    public class CityConnection
    {
        public int Id { get; }
        public CityName City1 { get; }
        public CityName City2 { get; }
        public TrainColor TrainColor { get; }
        public int Length { get; }

        public CityConnection(int id, CityName city1, CityName city2, TrainColor trainColor, int length)
        {
            Id = id;
            City1 = city1;
            City2 = city2;
            TrainColor = trainColor;
            Length = length;
        }
    }
}
