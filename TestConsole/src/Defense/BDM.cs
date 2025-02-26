namespace MazeShip;


public class BDM : IDefense
{
    public DefenseType type => DefenseType.BDM;

    public int Protection => 45;
    public int CoolDown => 5;
}