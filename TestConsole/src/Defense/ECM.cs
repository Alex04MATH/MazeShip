namespace MazeShip;


public class ECM : IDefense
{
    public DefenseType type => DefenseType.ECM;

    public int Protection => 30;

    public int CoolDown => 4;
    public int CurrentCoolDown { get; }
}