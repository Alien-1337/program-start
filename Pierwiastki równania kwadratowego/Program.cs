using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który oblicza pierwiastki równania kwadratowego ax2 + bx + c = 0. Zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury przez użytkownika.
//Wszystkie zmienne wyświetl na ekranie z dokładnością do dwóch miejsc po przecinku.

namespace Pierwiastki_równania_kwadratowego
{

    internal class Program
    {
        static void Pierwiastki()
        {
            Console.WriteLine("Podaj współczynniki równania kwadratowego ax^2 + bx + c = 0:");

            Console.Write("Podaj a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Podaj c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double pierwiastekDelta = Math.Sqrt(delta);
                double x1 = (-b + pierwiastekDelta) / (2 * a);
                double x2 = (-b - pierwiastekDelta) / (2 * a);

                Console.WriteLine($"Miejsca zerowe: x1 = {x1:F2}, x2 = {x2:F2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Równanie ma jedno miejsce zerowe: x = {x:F2}");
            }
            else
            {
                Console.WriteLine("Brak miejsc zerowych.");
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Pierwiastki();
        }
    }

}
        






