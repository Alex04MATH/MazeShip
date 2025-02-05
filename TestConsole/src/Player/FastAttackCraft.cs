namespace MazeShip
{
    public class FastAttackCraft : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.FastAttackCraft;
        public Position position { get; }
        public int BaseSpeed => 5;
        public int CoolDown => 1;
        public int Head => 75;
        public FastAttackCraft(string id, Position position)
        {
            Id = id;
            this.position = position;
        }
        public void UseAbility()
        {

        }
    }
}