using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace MazeShip
{
    public static class ValidatePosition
    {
        public static bool ValidTokenPosition(Position position, Cell[,] maze)
        {
            if (position.x >= maze.GetLength(0) || position.y >= maze.GetLength(1)) return false;

            var cell = maze[position.x, position.y];
            if (cell.IsFree) return true;
            if (cell.IsWall) return false;

            return true;
        }
    }
}