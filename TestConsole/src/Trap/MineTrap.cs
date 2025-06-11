namespace MazeShip
{
    public class MineTrap : ITrap
    {
        public string Name => "Mines";
        public Position position { get; }
        public int Damage => 20;
        public int Duration => 0;

        public MineTrap(Position position)
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