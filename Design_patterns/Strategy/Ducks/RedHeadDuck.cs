using Design_patterns.Strategy.Actions;

namespace Design_patterns.Strategy.Ducks
{
  public class RedHeadDuck : Duck
  {
    public RedHeadDuck(IFlyBehavior fly, IQuackBehavior quack)
    {
      this._flyBehavior = fly;
      this._quackbehavior = quack;
    }
  }
}