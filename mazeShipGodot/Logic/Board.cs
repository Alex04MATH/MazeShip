using Godot;
using System;

public partial class Board : Node2D
{   
	
	[Export]
	public Texture2D freeCellTexture;
	[Export]
	public Texture2D obstacleTexture;
	private Cell[,] cellBoard;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
