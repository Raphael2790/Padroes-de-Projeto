using System.Collections.Generic;

namespace Design_patterns.Observer
{
  public class YoutubeChannel : ISubject
  {
    public int State { get; private set; }
    public string Name { get; private set; }
    protected List<IObserver> _observers;

    public YoutubeChannel(string name)
    {
      Name = name;
      _observers = new List<IObserver>();
    }

    public YoutubeChannel()
    {
      _observers = new List<IObserver>();
    }

    public void UpdateVideo()
    {
      System.Console.WriteLine("Video novo no canal {0}", Name);
      Notify();
    }

    public void UpdateName(string name)
    {
      System.Console.WriteLine("O canal {0} mudou de nome para {1}!", Name, name);
      Name = name;
      Notify();
    }

    public void Attach(IObserver observer)
    {
      System.Console.WriteLine($"Adicionando um inscrito ao canal, bem-vindo!");
      _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
      System.Console.WriteLine($"Perdemos um inscrito no canal que pena, mas volte quando quiser {(observer as Subscriber).Name}");
      _observers.Remove(observer);
    }

    public void Notify()
    {
      foreach (var observer in _observers)
      {
        observer.Update(this);
      }
    }
  }
}