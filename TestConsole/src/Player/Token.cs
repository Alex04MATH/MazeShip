namespace MazeShip
{
    public interface IToken
    {
        public string Id { get; }
        public TokenType type { get; }
        public Position position { get; }
        public int BaseSpeed { get; }
        public int CoolDown { get; }
        // public void Ability() { }
        public int Head { get; }
        public void UseAbility();

    }
}