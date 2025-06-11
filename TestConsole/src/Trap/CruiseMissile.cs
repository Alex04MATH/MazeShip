namespace MazeShip
{
    public class CruiseMissile : ITrap
    {
        public string Name => "CruiseMissile";
        public Position position { get; }
        public int Damage => 50;
        public int Duration => 0;
        public CruiseMissile(Position position)
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