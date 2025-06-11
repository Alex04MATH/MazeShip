namespace MazeShip;

public class MissileAttack : IAttack
{
    public AttackType type => AttackType.Missile;
    public int damage => 50;
    public int range => 6;
    public int CoolDown => 5;
    public int CurrentCoolDown { get; }
}