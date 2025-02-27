namespace MazeShip;

public class TorpedoAttack : IAttack
{
    public AttackType type => AttackType.Torpedo;
    public int damage => 26;
    public int range => 5;
    public int CoolDown => 3;
    public int CurrentCoolDown { get; }
}