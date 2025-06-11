namespace MazeShip
{
    public class Corvette : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.Corvette;
        public Position position { get; }
        public int BaseSpeed => 3;
        public int CoolDown => 1;
        public int Head => 90;

        public List<IAttack> Attacks => [new ArtilleryAttack(), new TorpedoAttack(), new SubmarineAttack()];
        public List<IDefense> Defenses => [new ArtilleryDefender(), new AntiAerial()];

        public Corvette(string id, Position position)
        {
            Id = id;
            this.position = position;
        }
        public void UseAbility()
        {

        }
    }
}