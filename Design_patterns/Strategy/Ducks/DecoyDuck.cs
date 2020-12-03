using Design_patterns.Strategy.Actions;

namespace Design_patterns.Strategy.Ducks
{
  public class DecoyDuck : Duck
  {
    public DecoyDuck(IFlyBehavior fly, IQuackBehavior quack)
    {
      this._quackbehavior = quack;
      this._flyBehavior = fly;
    }
  }
}