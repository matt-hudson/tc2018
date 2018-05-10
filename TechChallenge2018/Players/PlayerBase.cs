namespace TechChallenge2018.Players
{
    using TechChallenge2018.GameData.Enums;

    public abstract class PlayerBase
    {
        public string PlayerName { get; private set; }

        public TurnAction TurnStart()
        {
            return TurnAction.DrawCards;
        } 
    }
}
