namespace Design_patterns.Factory
{
  class FinancialStatementLinkFactory : ILinkCreator
  {
    public override ILink FactoryMethod()
    {
      return new FinancialStatementLink();
    }
  }
}