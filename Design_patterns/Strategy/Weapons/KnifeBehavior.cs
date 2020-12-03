namespace Design_patterns.Strategy.Weapons
{
  public class KnifeBehavior : IWeaponBehavior
  {
    public void useWeapon()
    {
      System.Console.WriteLine("Usando uma faca!");
    }
  }
}