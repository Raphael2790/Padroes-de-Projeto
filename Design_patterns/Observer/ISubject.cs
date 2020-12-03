using System;

namespace Design_patterns.Observer
{
  public interface ISubject
  {
    //Metodos de uma interface devem ser virtual ou abstract
    //virtual podem ser sobrescritos
    //abstract são 
    abstract void Attach(IObserver observer);
    abstract void Detach(IObserver observer);
    abstract void Notify();

  }
}