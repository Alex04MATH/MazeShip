namespace MazeShip;

public class AerialAttack : IAttack
{
    public AttackType type => AttackType.Aerial;
    public int damage => 39;
    public int range => 5;
    public int CoolDown => 3;
    public int CurrentCoolDown { get; }

    public AerialAttack()
    {

    }
}