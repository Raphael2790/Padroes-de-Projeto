namespace Design_patterns.Factory
{
  abstract class ILinkCreator
  {
    public abstract ILink FactoryMethod();

    public string SomeOperation()
    {
      var link = FactoryMethod();

      var result = "Creator: The same creator's code has just worked with "
              + link.Operation();

      return result;
    }
  }
}