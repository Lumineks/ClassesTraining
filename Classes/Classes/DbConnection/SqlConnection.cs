using System;

namespace Classes
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection)
            : base(connection)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Sql connection has been opened");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Sql connection has been closed");
        }

        
    }
}
