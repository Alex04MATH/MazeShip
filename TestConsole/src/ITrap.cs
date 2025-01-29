using System.Security.Principal;

namespace MazeShip
{
    public interface ITrap
    {
        string Name { get; }
        void Activate();
    }
}