using System.Diagnostics.Contracts;

namespace MazeShip;

public class SubmarineAttack : IAttack
{
    public AttackType type => AttackType.Submarine;
    public int damage => 20;
    public int range => 3;
    public int CoolDown => 2;
    public int CurrentCoolDown { get; }
}