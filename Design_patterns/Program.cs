using System;
using Design_patterns.Factory;
using Design_patterns.Observer;
using Design_patterns.Strategy.Actions;
using Design_patterns.Strategy.Characters;
using Design_patterns.Strategy.Ducks;
using Design_patterns.Strategy.Weapons;

namespace Design_patterns
{
  class Program
  {
    static void Main(string[] args)
    {
      //ImplementsDesignPatternStrategy();

      // ImplementsDesignPatternObserver();

      var linkCreator = new FinancialStatementLinkFactory();
      LinkCode(linkCreator);
      System.Console.WriteLine(linkCreator.SomeOperation());
    }
    public static void LinkCode(ILinkCreator creator)
    {
      System.Console.WriteLine("Client: I'm not aware of the creator's class, but it still works.\n" + creator.SomeOperation());
    }

    private static void ImplementsDesignPatternObserver()
    {
      var channel = new YoutubeChannel("Programando em C#!");
      var subscriber = new Subscriber("Raphael");
      var subscriber2 = new Subscriber("Junior");
      var subscriber3 = new Subscriber("Miguel");
      var vipSub = new VipSubscriber("Victor");


      channel.Attach(subscriber);
      channel.Attach(subscriber2);

      channel.UpdateVideo();

      channel.UpdateName("Programando agora em Python!");

      channel.Attach(subscriber3);

      channel.Detach(subscriber);

      channel.Attach(vipSub);

      channel.UpdateVideo();
    }

    static void ImplementsDesignPatternStrategy()
    {
      BaseCharacter cavaleiro = new Knight(new BowAndArrowBehavior());
      cavaleiro.setWeapon(new SwordBehavior());
      System.Console.Write("O cavaleiro está ");
      cavaleiro.Fight();

      BaseCharacter rainha = new Queen(new KnifeBehavior());
      System.Console.Write("A rainha está ");
      rainha.Fight();

      Duck mallardDuck = new MallardDuck(new FlyWithWings(), new Quack());
      mallardDuck.PerformFly();
      mallardDuck.PerformaQuack();

      Duck decoyDuck = new DecoyDuck(new FlyNoWay(), new MuteQuack());
      decoyDuck.PerformaQuack();
      decoyDuck.PerformFly();
    }
  }
}
