namespace MazeShip
{
    public class Frigate : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.Frigate;
        public Position position { get; }
        public int BaseSpeed => 4;
        public int CoolDown => 1;
        public int Head => 80;

        public Frigate(string id, Position position)
        {
            Id = id;
            this.position = position;
        }
        public void UseAbility()
        {

        }
    }
}