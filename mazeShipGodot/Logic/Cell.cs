using Godot;
using System;

public class Cell 
{
  public bool isObstacle{get;set;}
  public bool isTrap{get;set;}
  private object container;
  private TypeTrap typeTrap;
  public TypeTrap NewTypeTrap(TypeTrap typeTrap)
  {
    this.typeTrap=typeTrap;
    return typeTrap;
  }
  public object ContainerObject{set=>value=container;}
  public Cell()
  {
    this.isObstacle=true;
    this.isTrap=false;
    this.typeTrap=TypeTrap.Ninguna;
  }
}
public enum TypeTrap
{
    Ninguna,
    Mine,
}
