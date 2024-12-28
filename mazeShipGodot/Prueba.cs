using Godot;
using System;
using MazeShipLogic;
namespace GodotMaze{
public partial class Prueba : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	  Tablero tablero= new Tablero(3);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
}
