using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwersje
{
    internal class Program
    {
        const double zmienna5 = 2;
        static int zmienna1 = 1;
        static byte zmienna2 = 2;
        static double zmienna3 = 3.14;
        static string zmiennax = "";
        static DateTime zmienna4 = DateTime.Now;
        static void Main(string[] args)
        {
            // zmienna1 = zmienna2; // konwersja niejawna
            procedure2();
        }

        static void procedure2()
        {
            // zmienna2 = (byte)zmienna3; // konwersja jawna
            //zmiennax = zmienna3.ToString();  //konwersja jawna do stringu - ogólnie konwersja to przypisaneie wartośći z innego typu do zmiennej   
            //zmienna2 = Convert.ToByte(zmienna3);
            Console.WriteLine(zmienna4);
            zmienna1 = (int)(zmienna4.Subtract(new DateTime(1970,1,1))).TotalSeconds; // 
            Console.WriteLine(zmienna1);

            zmienna4 = new DateTime(1970, 1, 1,0,0,0,DateTimeKind.Utc).AddSeconds(zmienna1);
            Console.WriteLine(zmienna4.ToLocalTime());
            float a = 222.3F; // literał F mówiący, że to float
            Console.WriteLine(a);
            string s1= "\amyszka \r Mickey \r"; // \r wrzucenie tekstu pomiedzy r na poczatek tekstu zastępując tekst
                                                // \t to tabulator      \v pionowy znak tabulacji
                                                // \za pomocą tego możęmy wpisywać apostroft albo inne zakazane znaki
            Console.WriteLine(s1);
            Console.WriteLine(zmienna5 + 5);
        }
    }

}
