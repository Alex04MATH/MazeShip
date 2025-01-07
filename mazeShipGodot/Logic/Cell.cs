using Godot;
using System;

public class Cell 
{
  public bool isObstacle{get;set;}
  public bool isTrap{get;set;}
  private object container;
  private bool busy;
  private int count=1;
  private TypeTrap typeTrap;
  public int Walk{get=>count;}
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
    busy=false;
  }
  public Cell(object container)
  {
    this.container=container;
    if(container !=null)
    {
      isObstacle=false;
      isTrap=false;
      typeTrap=TypeTrap.Ninguna;
      busy=true;
    }
  }
}
public enum TypeTrap
{
    Ninguna,
    Mine,
}
