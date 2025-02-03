namespace MazeShip
{
    public class Destroyer : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.Destroyer;
        public Position position { get; }
        public int BaseSpeed => 5;
        public int CoolDown => 1;
        public int Head => 110;

        public Destroyer(string id, Position position)
        {
            Id = id;
            this.position = position;
        }

        public void UseAbility()
        {

        }
    }
}