namespace MazeShip
{
    public class HuntingTrap : ITrap
    {
        public string Name => "HuntingTrap";
        public Position position { get; }
        public int Damage => 20;
        public int Duration => 0;
        public HuntingTrap(Position position)
        {
            this.position = position;
        }
        public void Activate()
        {

        }
        public void Deactivate()
        {

        }
    }
}