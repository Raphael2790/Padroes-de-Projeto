namespace Design_patterns.Strategy.Weapons
{
  public class BowAndArrowBehavior : IWeaponBehavior
  {
    public void useWeapon()
    {
      System.Console.WriteLine("Usando um arco e flecha!");
    }
  }
}