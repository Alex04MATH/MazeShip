namespace MazeShip;

public class Submarine : IToken
{
    public string Id { get; }
    public TokenType type => TokenType.Submarine;
    public Position position { get; }
    public int BaseSpeed => 7;
    public int CoolDown => 3;
    public int Head => 85;

    public List<IAttack> Attacks => [new TorpedoAttack(), new ArtilleryAttack()];
    public List<IDefense> Defenses => [new AntiMine()];

    public Submarine(string id, Position position)
    {
        Id = id;
        this.position = position;
    }
    public void UseAbility()
    {

    }
}