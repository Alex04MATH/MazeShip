namespace MazeShip;

public interface IDefense
{
    public DefenseType type { get; }
    public int Protection { get; }
    public int CoolDown { get; }
    public int CurrentCoolDown { get; }
    public void Defender(IAttack attacker, IToken DefenderToken)
    {

    }
}