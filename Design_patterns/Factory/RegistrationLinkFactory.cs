namespace Design_patterns.Factory
{
  class RegistrationLinkFactory : ILinkCreator
  {
    public override ILink FactoryMethod()
    {
      return new RegistrationLink();
    }
  }
}