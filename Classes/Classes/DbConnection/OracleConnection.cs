using System;

namespace Classes
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection)
            : base(connection)
        {

        }
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle connection has been opened");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection has been closed");
        }

        
    }
}
