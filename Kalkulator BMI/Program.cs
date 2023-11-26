using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Zaimplementuj kalkulator BMI (wskaźnik masy ciała, ang. body mass index) masa ciała[kg]/wzrost^2 [m].
//Użytkownik jest proszony o podanie swojej wagi i wzrostu. Wynik obliczeń wyświetl w konsoli.

namespace Kalkulator_BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoją wagę");
            double waga = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w metrach np. 1,60");
            double wzrost = Convert.ToDouble(Console.ReadLine());
            double BMI = waga / (wzrost * wzrost);
            Console.WriteLine(BMI);
            Console.ReadKey();
        }
    }
}
