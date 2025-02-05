using System;
namespace MazeShip
{
  public class Cell
  {
    public Position position { get; }
    private bool isWall;
    private bool isFree;
    public const int Steps = 1;
    public bool IsWall => isWall;
    public bool IsFree => isFree;
    public ITrap? Trap { get; }
    public IToken? Token { get; }
    public Cell(int x, int y, bool isWall)
    {
      this.isWall = isWall;
      isFree = !isWall;
      position = new Position(x, y);
    }

    public void CreateFreeCell()
    {
      isWall = false;
      isFree = true;
    }
    public void CreateWall()
    {
      isWall = true;
      isFree = false;
    }
  }
  public struct Position
  {
    public int x { get; }
    public int y { get; }

    public Position(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
  }
}
