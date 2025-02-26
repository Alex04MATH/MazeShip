namespace MazeShip;

public class AntiAerial : IDefense
{
    public DefenseType type => DefenseType.antiAerial;
    public int Protection => 20;
    public int CoolDown => 4;
}