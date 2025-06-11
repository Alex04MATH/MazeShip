// See https://aka.ms/new-console-template for more information
using MazeShip;
using Microsoft.Win32.SafeHandles;
Console.WriteLine("Hello, World!");
MazeCell a = new MazeCell();
IToken token = TokenFactory.CreateShip(TokenType.AircraftCarrier, "Hola", new Position(0, 0));
System.Console.WriteLine(token.CoolDown);

void Print<T>(T Hola)
{
    Console.WriteLine(Hola);
}

foreach (var i in token.Attacks)
{
    Print(i);
    Print("Daño: " + i.damage);
    Print("Rango: " + i.range);
    Print("CoolDown: " + i.CoolDown);
    Print("Current: " + i.CurrentCoolDown);
    Print(token.Head);
}
