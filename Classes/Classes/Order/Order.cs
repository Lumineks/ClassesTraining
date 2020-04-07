using System;
using System.Collections.Generic;

namespace Classes
{
    public class Order : IOrder
    {
        private List<Menu> OrderList;
        private List<Menu> GeneralMenu;
        public int TotalCost
        {
            get
            {
                var sum = 0;
                foreach (var item in OrderList)
                {
                    sum += item.ItemCost;
                }
                return sum;
            }            
        }
        public Order(List<Menu> gMenu)
        {
            GeneralMenu = gMenu;
            OrderList = new List<Menu>();
        }
        public void MakeOrder(ConsolePrinter printer)
        {
            var wish = "";
            printer.Print("What do you want to order?");
            while (true)
            {
                wish = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(wish))
                    throw new ArgumentException("You can't add nothing");

                if (wish.ToLower() == "no")
                    break;

                while (!IsExistInMenu(wish.ToLower()))
                {
                    printer.Print("Invalid order, try again");
                    wish = Console.ReadLine();
                }

                OrderList.Add(GeneralMenu[GeneralMenu.FindIndex(0, x => x.ItemName == wish)]);
                printer.Print("Okay. Something else? Type *No*, if you want to confirm your order");
            }
        }
        public void GetInfo(string name, ConsolePrinter printer)
        {
            printer.Print("\nFor:" + name);
            foreach (var item in OrderList)
            {
                printer.Print(item.ItemName);
            }
            printer.Print("Cost: " + TotalCost);
        }
        
        private bool IsExistInMenu(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || GeneralMenu.Count == 0)
                throw new InvalidOperationException("Invalid name or menu is empty");

            if (GeneralMenu.Exists(x => x.ItemName.ToLower() == name))
                return true;

            return false;
        }
    }

}
