namespace MazeShip
{
    public static class TokenFactory
    {
        public static IToken CreateShip(TokenType type, string id, Position position)
        {
            return type switch
            {
                TokenType.AircraftCarrier => new AircraftCarrier(id, position),
                TokenType.Battleship => new Battleship(id, position),
                TokenType.Destroyer => new Destroyer(id, position),
                TokenType.Frigate => new Frigate(id, position),
                TokenType.Corvette => new Corvette(id, position),
                TokenType.MineLayer => new MineLayer(id, position),
                TokenType.MineSweeper => new MineSweeper(id, position),
                TokenType.AuxiliaryAndSupportShip => new AuxiliaryAndSupportShip(id, position),

                _ => throw new TokenException(),
            };
        }
    }
}