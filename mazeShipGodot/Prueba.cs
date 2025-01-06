using Godot;
using System;

public partial class Prueba : GridContainer
{
	[Export]
	public NodePath GridContainerPath;
	
	public override void _Ready()
	{
	  GridContainer gridContainer=GetNode<GridContainer>(GridContainerPath);
	  gridContainer.Columns=27;
	  for(int i=0;i<(27*27)-1;i++)
	  {
		Random a=new Random();
		string[] spriteDirection={"res://Sprite/Water78x78.jpeg","res://Sprite/IslandObstacule98x98.jpeg"};
		TextureRect textureRect=new TextureRect();
		int b=a.Next(0,2);
		textureRect.Texture=(Texture2D) GD.Load(spriteDirection[b]);
		gridContainer.AddChild(textureRect);
	  }
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
