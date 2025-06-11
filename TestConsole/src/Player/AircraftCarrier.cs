namespace MazeShip
{
    public class AircraftCarrier : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.AircraftCarrier;
        public Position position { get; }
        public int BaseSpeed => 3;
        public int CoolDown => 1;
        public int Head => 120;
        public List<IAttack> Attacks => [new AerialAttack(), new ArtilleryAttack(), new TorpedoAttack()];
        public List<IDefense> Defenses => [new AntiAerial(), new AntiMine(), new ArtilleryDefender(), new ECM()];

        public AircraftCarrier(string id, Position position)
        {
            Id = id;
            this.position = position;
        }
        public void UseAbility()
        {

        }
    }
}