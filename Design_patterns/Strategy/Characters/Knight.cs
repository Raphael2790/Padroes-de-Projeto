using Design_patterns.Strategy.Weapons;

namespace Design_patterns.Strategy.Characters
{
  public class Knight : BaseCharacter
  {
    public Knight()
    {
    }

    public Knight(IWeaponBehavior weapon)
    {
      _weapon = weapon;
    }

    public override void Fight()
    {
      _weapon.useWeapon();
    }

  }
}