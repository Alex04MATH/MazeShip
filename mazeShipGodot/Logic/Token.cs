using Godot;
using System;
using System.Runtime.CompilerServices;

public class Token
{
  private TokenName name;
  private TokenWeapon weapon;
  public Token(TokenName tokenName)
  {
    this.name=tokenName;
  }
  private enum TokenWeapon
  {

  }
//   private TokenWeapon weaponForToken(TokenName tokenName)
//   {
    
//   }
}
public enum TokenName
  {
    Submarine,
    Carrier,
    Destroy,
  }

