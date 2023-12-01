using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który za pomocą instrukcji do ... while wyświetla liczby całkowite z przedziału od 1 do 20 podniesione do kwadratu. Wynik obliczeń wyświetl w konsoli.

namespace Pętla_do.@while
{
    internal class Program
    {
        public static void ŁajlLup() 
        {
            int ochotnik = 1;
            do
            {
                Console.WriteLine($"Liczba {ochotnik} podniesiona do kwadratu wynosi " + Math.Pow(ochotnik, 2));
                ochotnik++;
            } while (ochotnik <= 20);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ŁajlLup();
        }
    }
}
