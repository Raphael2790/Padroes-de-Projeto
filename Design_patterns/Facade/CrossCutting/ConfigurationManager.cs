using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.Facade.CrossCutting
{
    public class ConfigurationManager : IConfigurationManager
    {
        public string GetValue(string sectionName)
        {
            return sectionName;
        }
    }
}
