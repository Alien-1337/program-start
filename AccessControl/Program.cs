using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Zasymuluj kontrolę dostępu do zasobów na podstawie wieku. Użytkownik jest proszony o podanie swojego wieku. Niech program na tej podstawie podejmie decyzję,
//czy użytkownik może dostać dostęp. Rozważ trzy przypadki:

//Jeżeli użytkownik ma +18 lat, niech program wypisze w konsoli "Access granted"
//Jeżeli użytkownik ma 15 - 18 lat, niech program zada dodatkowe pytanie "Do you have parental consent?". Jeżeli tak, niech program wypisze w konsoli "Access granted, jeżeli nie - "Access denied"
//Jeżeli użytkownik ma mniej niż 15 lat, niech program wypisze w konsoli "Access denied"

namespace AccessControl
{
    internal class Program
    {

        static void Access()
        {
            Console.WriteLine("Podaj swój wiek: ");
            int wiek = Int32.Parse(Console.ReadLine());
            if (wiek > 18)
            {
                Console.WriteLine("Access Granted");
            }
            else if (wiek < 15)
            {
                Console.WriteLine("Access Denied");
            }
            else if (wiek >= 15 && wiek < 18)
            {
                Console.WriteLine("Do you have parental consent Y/N?");
                string ParentalConsent = Console.ReadLine().ToString();
                if (ParentalConsent == "Y")
                {
                    Console.WriteLine("Access Granted");
                }
                else if (ParentalConsent == "N")
                {
                    Console.WriteLine("Access Denied");
                }
            }
            Console.ReadLine(); // Aby program nie zakończył się od razu
        }
        static void Main(string[] args)
        {
            Access();
        }
    }
}
