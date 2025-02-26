namespace MazeShip;

public class ArtilleryAttack : IAttack
{
    public AttackType type => AttackType.Artillery;
    public int damage => 14;
    public int range => 2;
    public int CoolDown => 1;
}