namespace MazeShip;

public interface IAttack
{
    public AttackType type { get; }
    public int damage { get; }
    public int range { get; }
    public int CoolDown { get; }
    public int CurrentCoolDown { get; }
    public void Attack(IToken attackerToken, IToken defenderToken)
    {

    }
}