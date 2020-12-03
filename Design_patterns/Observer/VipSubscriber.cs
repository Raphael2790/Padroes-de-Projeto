namespace Design_patterns.Observer
{
  public class VipSubscriber : IObserver
  {
    public string Name { get; private set; }
    public VipSubscriber(string name)
    {
      this.Name = name;

    }
    public void Update(ISubject subject)
    {
      System.Console.WriteLine($"Um usuário {Name} vip recebeu as notificações do canal {(subject as YoutubeChannel).Name}");
    }
  }
}