using Design_patterns.Strategy.Weapons;

namespace Design_patterns.Strategy.Characters
{
  public class King : BaseCharacter
  {
    public King()
    {
    }

    public King(IWeaponBehavior weapon)
    {
      this._weapon = weapon;
    }

    public override void Fight()
    {
      _weapon.useWeapon();
    }
  }
}