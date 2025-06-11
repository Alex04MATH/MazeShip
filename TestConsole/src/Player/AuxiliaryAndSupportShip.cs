namespace MazeShip
{
    public class AuxiliaryAndSupportShip : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.AuxiliaryAndSupportShip;
        public Position position { get; }
        public int BaseSpeed => 7;
        public int CoolDown => 2;
        public int Head => 220;
        public List<IAttack> Attacks => [new ArtilleryAttack(), new TorpedoAttack()];
        public List<IDefense> Defenses => [new AntiMine(), new ArtilleryDefender(), new AntiAerial()];

        public AuxiliaryAndSupportShip(string id, Position position)
        {
            Id = id;
            this.position = position;
        }

        public void UseAbility()
        {

        }
    }
}