namespace Design_patterns.Strategy.Actions
{
  public class FlyWithWings : IFlyBehavior
  {
    public void Fly()
    {
      System.Console.WriteLine("Voando com asas");
    }
  }
}