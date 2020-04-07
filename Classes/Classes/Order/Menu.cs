using System;

namespace Classes
{
    public class Menu
    {
        public string ItemName { get; private set; }
        public int ItemCost { get; private set; }
        public void PrintItem(ConsolePrinter printer)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            printer.Print("Name: " + ItemName + "\tCost: " + ItemCost);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public Menu(string name, int cost)
        {
            if (string.IsNullOrWhiteSpace(name) || cost <= 0)
                throw new ArgumentException("Name can't be empty and cost must be more than 0");

            ItemName = name;
            ItemCost = cost;
        }
    }

}
