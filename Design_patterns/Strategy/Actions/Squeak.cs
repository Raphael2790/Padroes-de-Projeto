namespace Design_patterns.Strategy.Actions
{
  public class Squeak : IQuackBehavior
  {
    public void quack()
    {
      System.Console.WriteLine("Esguicho pato de borracha");
    }
  }
}