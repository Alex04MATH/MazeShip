namespace MazeShip
{
    public class Battleship : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.Battleship;
        public Position position { get; }
        public int BaseSpeed => 3;
        public int CoolDown => 2;
        public int Head => 150;

        public Battleship(string id, Position position)
        {
            Id = id;
            this.position = position;
        }

        public void UseAbility()
        {

        }
    }
}