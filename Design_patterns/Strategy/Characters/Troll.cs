using Design_patterns.Strategy.Weapons;

namespace Design_patterns.Strategy.Characters
{
  public class Troll : BaseCharacter
  {
    public Troll()
    {

    }

    public Troll(IWeaponBehavior weapon)
    {
      this._weapon = weapon;
    }

    public override void Fight()
    {
      _weapon.useWeapon();
    }
  }
}