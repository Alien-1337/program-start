using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który za pomocą pętli for dla danych wartości x zmieniających się w przedziale od 0 do 10 obliczy wartość funkcji y = root(3^2)*x.Wynik wyświetl w konsoli.

//Uwaga: root() oznacza pierwiastek z liczby znajdującej się w nawiasie. Pamiętaj o prawidłowej kolejności wykonywania działań!

namespace Pętla_For
{
   
    internal class Program
    {

        public static void WartośćFunkcji()
        {
            for (int x = 0; x <= 10; x++)
            {
                double y = Math.Sqrt(3 * 3) * x;
                Console.WriteLine("Jeśli x = " + x + " to y wychodzi " + y);
                
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            WartośćFunkcji();
        }
    }
}
