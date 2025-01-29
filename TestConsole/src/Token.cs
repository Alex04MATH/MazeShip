namespace MazeShip
{
    public abstract class Token
    {
        public string Id { get; }

        public Position position;
        public abstract int BaseSpeed { get; }
        public abstract int ColdDown { get; }

        protected Token(string id, Position position)
        {
            Id = id;
            this.position = position;
        }

        public abstract void UseAbility();

    }
}