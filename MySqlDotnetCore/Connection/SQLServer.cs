using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySqlDotnetCore.Connection
{
    public class SQLConnection
    {
        public Models.Connection GetConnection()
        {
            var connection = new Models.Connection();

            connection.connectionstring = "Data Source = 10.249.1.125; Database=test;User ID = Appsa; Password=Opuswebsql2017;Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return connection;
        }
    }
}
