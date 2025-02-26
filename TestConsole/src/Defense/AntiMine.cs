namespace MazeShip;


public class AntiMine : IDefense
{
    public DefenseType type => DefenseType.antiMine;
    public int Protection => 15;
    public int CoolDown => 4;
}