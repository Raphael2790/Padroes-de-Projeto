using Design_patterns.Strategy.Weapons;

namespace Design_patterns.Strategy.Characters
{
  public abstract class BaseCharacter
  {
    protected IWeaponBehavior _weapon { get; set; }

    public void setWeapon(IWeaponBehavior weapon)
    {
      this._weapon = weapon;
    }
    public virtual void Fight()
    {

    }
  }
}