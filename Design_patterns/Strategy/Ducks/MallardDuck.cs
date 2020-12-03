using Design_patterns.Strategy.Actions;

namespace Design_patterns.Strategy.Ducks
{
  public class MallardDuck : Duck
  {
    public MallardDuck(IFlyBehavior canFly, IQuackBehavior canQuack)
    {
      this._quackbehavior = canQuack;
      this._flyBehavior = canFly;
    }
  }
}