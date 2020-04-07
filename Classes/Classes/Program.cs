using System;
using System.IO;
using System.Collections.Generic;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var printer = new ConsolePrinter();
            printer.Print("Welcome, how many people are going to make an order?");
            
            var countOfPeople = 0;
            while(!int.TryParse(Console.ReadLine(), out countOfPeople))
            {
                printer.Print("Invalid number, try again");
            }

            var menu = CreationOfMenu();

            printer.Print("\nHere is our menu:");
            foreach (var item in menu)
            {
                item.PrintItem(printer);
            }
            var People = new List<Person>();
            for (int i = 0; i < countOfPeople; i++)
            {
                printer.Print("\nOrder for person " + (i+1) + " What's your name?");
                var name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                    throw new FormatException("Invalid name");

                People.Add(new Person(name, menu, new Order(menu)));
                People[i].Order.MakeOrder(printer);
            }

            foreach (var person in People)
            {
                person.Order.GetInfo(person.Name, printer);
            }

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
        public static void UseOrder()
        {

        }
        public static List<Menu> CreationOfMenu()
        {
            var menu = new List<Menu>();
            var path = @"F:/Проекты VS/Classes Trainings/Classes/Classes/Menu.txt";
            if (!File.Exists(path))
                throw new FileNotFoundException("Couldn't find menu file");

            var allLines = File.ReadAllLines(path);
            for (int i = 0; i < allLines.Length; i++)
            {
                var str = allLines[i].Split(' ');
                menu.Add(new Menu(str[0], int.Parse(str[1]))); // Adding new items to menu - Name and Cost
            }
            return menu;
        }
    }
}
