namespace MazeShip
{
    public class Frigate : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.Frigate;
        public Position position { get; }
        public int BaseSpeed => 4;
        public int CoolDown => 1;
        public int Head => 80;

        public List<IAttack> Attacks => [new AerialAttack(), new ArtilleryAttack(), new MissileAttack(), new TorpedoAttack()];
        public List<IDefense> Defenses => [new AntiAerial(), new AntiMine(), new ArtilleryDefender()];

        public Frigate(string id, Position position)
        {
            Id = id;
            this.position = position;
        }
        public void UseAbility()
        {

        }
    }
}