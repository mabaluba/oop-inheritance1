using System;
using System.Security.Cryptography.X509Certificates;


namespace oop_inheritance1
{
    class Printer
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
    class PrintRed:Printer
    {
        public PrintRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        
        /*public void RedText(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //Print(value);
        }*/
    }
    class PrintBlue:Printer
    {
        public PrintBlue()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.Clear();
            //Console.BackgroundColor = ConsoleColor.White;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Whaaat?!!!?!!";
            Printer x = new();
            x.Print(text);
            PrintBlue b = new();
            b.Print(text);
            PrintRed a = new();
            a.Print(text);
            x = a;
            x.Print(text);
            
            x = b;// печатает красный, а должен синий... не понятно почему
            x.Print(text);
        }
    }
}