using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
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
            
    }    
}
