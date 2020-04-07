using System;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            Console.ReadLine();
        }
        public static void UseShapes()
        {
            var list = new List<Shape>();
            var circle = new Circle();
            var recktangle = new Recktangle();

            list.Add(circle);
            list.Add(recktangle);
            Drawer.DrawPicture(list);
        }
        public static void UseDbConnections()
        {
            var sql = new SqlConnection("Sql connection");
            var oracle = new OracleConnection("Oracle connection");

            var command = new DbCommand(oracle, "Oracle instruction");
            var command2 = new DbCommand(sql, "Sql instruction");
            command.Execute();
            command2.Execute();

        }
    }    
}
