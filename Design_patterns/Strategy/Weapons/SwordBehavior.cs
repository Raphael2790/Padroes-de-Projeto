namespace Design_patterns.Strategy.Weapons
{
  public class SwordBehavior : IWeaponBehavior
  {
    public void useWeapon()
    {
      System.Console.WriteLine("Usando uma espada!");
    }
  }
}