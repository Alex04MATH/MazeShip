using Godot;
using System;
using System.Runtime.CompilerServices;

public partial class CellGD : Node2D
{
   [Export]
   private Area2D cellObstacle;
   [Export]
   private Area2D cellFree;
   private Cell cell;

   public bool Ocupaded{get;private set;}=false;

   public CellGD()
   {
     Ocupaded=false;
     cellObstacle=GetNode<Area2D>("CellObstacle");
     cellFree=GetNode<Area2D>("CellFree");
     UpdateStatus();
   }

   public void ChangeStatus(bool ocupaded)
   {
     Ocupaded=ocupaded;
     UpdateStatus();
   }

   private void UpdateStatus()
   {
     if(Ocupaded==true)
     {     
     cellFree.Visible=true;
     cellFree.Monitoring=true;
     }
     else
     {
     cellObstacle.Visible=true;
     cellObstacle.Monitoring=true;
     }
   }
    public override void _Ready()
    {
      CellGD ced=new CellGD();
      ced.UpdateStatus();
    }


}
