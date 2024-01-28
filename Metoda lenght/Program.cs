using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który umożliwia odczytywanie długości łańcucha zapamiętanego w odpowiedniej zmiennej.
//Program powinien mierzyć długość łańcucha nazwa miasta i województwo. Użytkownik podaje nazwę miasta i województwo. Skorzystaj z metody Length,
//a wynik wyświetl w postaci np. "Nazwa miasta Warszawa zawiera 8 liter. Nazwa województwa Mazowieckie zawiera 11 liter."

namespace Metoda_lenght
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miasto = "";
            string wojewodztwo = "";

            Console.WriteLine("Wprowadź nazwę miasta");
            miasto = Console.ReadLine();
            Console.WriteLine("Wprowadź nazwę województwa");
            wojewodztwo = Console.ReadLine();
            Console.WriteLine($"Nazwa miasta {miasto} zawiera {miasto.Length} liter. Nazwa województwa {wojewodztwo} zawiera {wojewodztwo.Length} liter.");
            Console.ReadKey();

        }
    }
}
