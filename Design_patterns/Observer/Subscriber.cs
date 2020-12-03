namespace Design_patterns.Observer
{
  public class Subscriber : IObserver
  {
    public string Name { get; private set; }
    public Subscriber(string name)
    {
      Name = name;
    }
    public void Update(ISubject subject)
    {
      System.Console.WriteLine($"O usuário {Name} recebeu as notificações do canal {(subject as YoutubeChannel).Name}");
    }
  }
}