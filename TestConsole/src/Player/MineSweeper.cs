namespace MazeShip
{
    public class MineSweeper : IToken
    {
        public string Id { get; }
        public TokenType type => TokenType.MineSweeper;
        public Position position { get; }
        public int BaseSpeed => 7;
        public int CoolDown => 3;
        public int Head => 95;
        public List<IAttack> Attacks => [new ArtilleryAttack(), new TorpedoAttack()];
        public List<IDefense> Defenses => [new ArtilleryDefender(), new AntiMine()];

        public MineSweeper(string id, Position position)
        {
            Id = id;
            this.position = position;
        }
        public void UseAbility()
        {

        }
    }
}