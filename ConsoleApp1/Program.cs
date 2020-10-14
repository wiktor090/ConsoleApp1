using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            String tekst = "tekst";
            Console.WriteLine(tekst);
            tekst = Console.ReadLine();
            Console.WriteLine(tekst);
            Console.ReadLine();
            //Oczeiwanie na kliknięcie
            //konsole.ReadLine();
            Main(args);
        }
    }
}
