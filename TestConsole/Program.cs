// See https://aka.ms/new-console-template for more information
using MazeShip;
Console.WriteLine("Hello, World!");
MazeCell a = new MazeCell();
IToken token = TokenFactory.CreateShip(TokenType.AircraftCarrier, "Hola", new Position(0, 0));
System.Console.WriteLine(token.CoolDown);
