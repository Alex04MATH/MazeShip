namespace MazeShip
{
    public class ReefTrap : ITrap
    {
        public string Name => "Reef";
        public Position position { get; }
        public int Damage => 15;
        public int Duration => 2;

        public ReefTrap(Position position)
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