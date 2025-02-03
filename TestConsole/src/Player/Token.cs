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
        public void UseAbility();

        public int Head { get; }
    }
}