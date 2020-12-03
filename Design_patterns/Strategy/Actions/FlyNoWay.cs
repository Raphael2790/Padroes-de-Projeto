namespace Design_patterns.Strategy.Actions
{
  public class FlyNoWay : IFlyBehavior
  {
    public void Fly()
    {
      System.Console.WriteLine("Não posso voar");
    }
  }
}