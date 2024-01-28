using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który składa dowolne dwa łańcuchy tekstowe. Użytkownik podaje pierwszy i drugi łańcuch. Wyświetl wyniki tej operacji.

namespace Konkatenacja
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input1 = "";
            string input2 = "";

            Console.WriteLine("Podaj pierwszą część łańcucha");
            input1 = Console.ReadLine();
            Console.WriteLine("Podaj drugą część łańcucha");
            input2 = Console.ReadLine();
            Console.WriteLine(string.Concat(input1, input2));
            Console.ReadKey();
        }
    }
}
