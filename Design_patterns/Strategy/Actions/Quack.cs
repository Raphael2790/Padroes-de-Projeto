namespace Design_patterns.Strategy.Actions
{
  public class Quack : IQuackBehavior
  {
    public void quack()
    {
      System.Console.WriteLine("Pato grasnando");
    }
  }
}