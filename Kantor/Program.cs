using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Zaimplementuj kalkulator walutowy. Sprawdź obecne kursy wymiany walut i zakoduj je na stałe.
//Użytkownik jest proszony o podanie kwoty w PLN oraz waluty docelowej (do wyboru EUR, CHF, GBP).
//Niech program najpierw przelicza kwotę na walutę pośrednią w USD, a następnie na walutę docelową.
//Wynik przewalutowania wyświetl w konsoli.

namespace Kantor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double EUR = 0.91;
            double CHF = 0.88;
            double GBP = 0.79;
            double USD = 0.25;
            Console.WriteLine("Podaj kwotę którą chcesz zamienić w PLN");  
            double Kwota = Convert.ToDouble(Console.ReadLine());
            double PlnUsd = Kwota * USD;
            Console.WriteLine("Podaj na jaką walute chcesz zamienić");
            Console.WriteLine("1.EUR");
            Console.WriteLine("2.CHF");
            Console.WriteLine("3.GBP");
            int waluta = Int32.Parse(Console.ReadLine());

            switch (waluta) 
            {

                case 1: Console.WriteLine("Twoja ilość pieniędzy w EUR to" + PlnUsd * EUR);
                    break;

                case 2: Console.WriteLine("Twoja ilość pieniędzy w EUR to" + PlnUsd * CHF);
                    break;

                case 3: Console.WriteLine("Twoja ilość pieniędzy w EUR to" + PlnUsd * GBP);
                    break;
            }
            Console.ReadKey();

        }
    }
}
