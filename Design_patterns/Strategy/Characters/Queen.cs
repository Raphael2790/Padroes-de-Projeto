using Design_patterns.Strategy.Weapons;

namespace Design_patterns.Strategy.Characters
{
  public class Queen : BaseCharacter
  {
    public Queen()
    {
    }

    public Queen(IWeaponBehavior weapon)
    {
      this._weapon = weapon;
    }

    public override void Fight()
    {
      _weapon.useWeapon();
    }
  }
}