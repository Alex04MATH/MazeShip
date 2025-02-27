namespace MazeShip;


public class ArtilleryDefender : IDefense
{
    public DefenseType type => DefenseType.ArtilleryDefender;
    public int Protection => 10;
    public int CoolDown => 2;
    public int CurrentCoolDown { get; }
}