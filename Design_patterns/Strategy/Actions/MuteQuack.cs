namespace Design_patterns.Strategy.Actions
{
  public class MuteQuack : IQuackBehavior
  {
    public void quack()
    {
      System.Console.WriteLine("Pato mudo!");
    }
  }
}