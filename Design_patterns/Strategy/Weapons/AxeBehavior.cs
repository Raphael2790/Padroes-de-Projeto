namespace Design_patterns.Strategy.Weapons
{
  public class AxeBehavior : IWeaponBehavior
  {
    public void useWeapon()
    {
      System.Console.WriteLine("Usando um machado!");
    }
  }
}