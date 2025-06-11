namespace MazeShip
{
    public class MineLayer : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.MineLayer;
        public Position position { get; }
        public int BaseSpeed => 7;
        public int CoolDown => 3;
        public int Head => 95;

        public MineLayer(string id, Position position)
        {
            Id = id;
            this.position = position;
        }
        public void UseAbility()
        {

        }

    }
}