using System;

namespace Classes
{
    public class ConsolePrinter : Iprinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

}
