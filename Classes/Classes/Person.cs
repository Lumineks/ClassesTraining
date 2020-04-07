using System;
using System.Collections.Generic;

namespace Classes
{
    public class Person
    {
        public string Name { get; private set; }
        public readonly IOrder Order;
        public Person(string name, List<Menu> menu, Order order)
        {
            if (string.IsNullOrWhiteSpace(name) || menu.Count == 0)
                throw new ArgumentException("Invalid name or empty menu");

            Name = name;
            Order = order;
        }       
    }

}
