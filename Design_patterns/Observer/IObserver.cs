namespace Design_patterns.Observer
{
  public interface IObserver
  {
    abstract void Update(ISubject subject);
  }
}