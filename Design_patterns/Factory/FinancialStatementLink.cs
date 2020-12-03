namespace Design_patterns.Factory
{
  public class FinancialStatementLink : ILink
  {
    public string Url { get; set; }
    public string Operation()
    {
      return "Resultado de Financial Link";
    }
  }
}