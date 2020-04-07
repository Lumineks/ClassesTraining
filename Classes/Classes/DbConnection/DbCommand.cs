using System;

namespace Classes
{
    public class DbCommand
    {
        private string instruction;
        private readonly DbConnection db;
        public DbCommand(DbConnection db, string instruction)
        {
            if (String.IsNullOrWhiteSpace(db.ConnectionString))
                throw new NullReferenceException("There's no string connection");

            if (String.IsNullOrWhiteSpace(instruction))
                throw new NullReferenceException("There's no string connection");

            this.instruction = instruction;
            this.db = db;
        }
        public void Execute()
        {
            db.OpenConnection();
            Console.WriteLine("Instruction is being applied: " + instruction);
            db.CloseConnection();
        }
    }
}
