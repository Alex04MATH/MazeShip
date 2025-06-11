using System.Security.Principal;

namespace MazeShip
{
    public interface ITrap
    {
        public string Name { get; }
        public int Damage { get; }
        public Position position { get; }
        public int Duration { get; }
        public void Activate();
        public void Deactivate();
    }
}