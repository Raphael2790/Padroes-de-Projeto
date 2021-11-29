namespace Design_patterns.Facade.CrossCutting
{
    public interface IConfigurationManager
    {
        string GetValue(string sectionName);
    }
}
