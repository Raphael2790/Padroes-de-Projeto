using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns.FactoryExample2
{
    public abstract class DbFactory
    {
        //Factory Method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(DataBase dataBase)
        {
            switch (dataBase)
            {
                case DataBase.Oracle:
                    return new OracleFactory();
                case DataBase.SqlServer:
                    return new SqlFactory();
                default:
                    throw new NotImplementedException();
            }
        }
    }

    public enum DataBase
    {
        Oracle,
        SqlServer
    }
}
