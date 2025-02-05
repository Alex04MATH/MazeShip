namespace MazeShip
{
    public class OilTrap : ITrap
    {
        public string Name => "OilTrap";
        public Position position { get; }
        public int Damage => 14;
        public int Duration => 1;

        public OilTrap(Position position)
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