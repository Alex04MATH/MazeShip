namespace MazeShip
{
    public class PatrolBoatsAndCutters : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.PatrolBoatsAndCutters;
        public Position position { get; }
        public int BaseSpeed => 7;
        public int CoolDown => 1;
        public int Head => 70;

        public List<IAttack> Attacks => [new ArtilleryAttack(), new TorpedoAttack()];
        public List<IDefense> Defenses => [new ArtilleryDefender(), new AntiMine()];
        public PatrolBoatsAndCutters(string id, Position position)
        {
            Id = id;
            this.position = position;
        }
        public void UseAbility()
        {

        }
    }
}