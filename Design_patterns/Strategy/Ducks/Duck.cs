using Design_patterns.Strategy.Actions;

namespace Design_patterns.Strategy.Ducks
{
  public abstract class Duck
  {
    protected IFlyBehavior _flyBehavior;
    protected IQuackBehavior _quackbehavior;

    public void Swim() { }
    public virtual void Display() { }
    public void PerformFly()
    {
      this.SelfFlyBehavior();
    }
    public void PerformaQuack()
    {
      this.SelfQuackBehavior();
    }
    protected void SelfFlyBehavior()
    {
      this._flyBehavior.Fly();
    }
    protected void SelfQuackBehavior()
    {
      this._quackbehavior.quack();
    }

  }
}