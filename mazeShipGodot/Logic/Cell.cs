using Godot;
using System;

public class Cell
{
  private int x;
  private int y;

  public (int, int) Coordinate { get => (x, y); }

  private bool isWall;
  private bool isFree;
  private bool isTramp;
  public const int Steps = 1;
  public bool IsWall => isWall;
  public bool IsFree => isFree;
  public Cell(int x, int y, bool isWall)
  {
    this.isWall = isWall;
    isFree = !isWall;
    this.x = x;
    this.y = y;
  }

  public void CreateFreeCell()
  {
    isWall = false;
    isFree = true;
  }
  public void CreateWall()
  {
    isWall=true;
    isFree=false;
  }
}
