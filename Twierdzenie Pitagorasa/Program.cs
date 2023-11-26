using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Stwórz projekt w postaci aplikacji konsolowej.

//Zaimplementuj twierdzenie Pitagorasa a^2+b^2=c^2. Oblicz długość przeciwprostokątnej trójkąta prostokątnego o przyprostokątnych a = 3.5 i b = 6.
//Wynik obliczeń wyświetl w konsoli.


namespace Twierdzenie_Pitagorasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 3.5;
            double b = 6;
            double c = a * a + b * b;
            Console.WriteLine(Math.Sqrt(c));
            Console.ReadKey();
        }
    }
}
