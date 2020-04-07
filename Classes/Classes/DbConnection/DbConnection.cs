using System;

namespace Classes
{   
        public abstract class DbConnection
        {
            public string ConnectionString { get; set; }
            public TimeSpan TimeouT { get; set; }
            public DbConnection(string connection)
            {
                if (String.IsNullOrWhiteSpace(connection))
                    throw new Exception("invalid string connection");

                ConnectionString = connection;
            }
            public abstract void OpenConnection();
            public abstract void CloseConnection();
        }           
}
