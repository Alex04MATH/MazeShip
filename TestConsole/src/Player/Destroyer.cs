namespace MazeShip
{
    public class Destroyer : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.Destroyer;
        public Position position { get; }
        public int BaseSpeed => 4;
        public int CoolDown => 1;
        public int Head => 110;
        public List<IAttack> Attacks => [new MissileAttack(), new ArtilleryAttack(), new TorpedoAttack(), new SubmarineAttack()];
        public List<IDefense> Defenses => [new ECM(), new BDM(), new ArtilleryDefender()];

        public Destroyer(string id, Position position)
        {
            Id = id;
            this.position = position;
        }

        public void UseAbility()
        {

        }
    }
}