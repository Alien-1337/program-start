using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konwersje
{
    internal class Program
    {
        const double zmienna5 = 2;
        static int zmienna1 = 1;
        static int zmienna1a = 4;
        static byte zmienna2 = 2;
        static double zmienna3 = 3.14;
        static string zmiennax = "";
        static DateTime zmienna4 = DateTime.Now;
        static void Main(string[] args)
        {
            // zmienna1 = zmienna2; // konwersja niejawna
            operatory();
        }

        static void procedure2()
        {
            // zmienna2 = (byte)zmienna3; // konwersja jawna
            //zmiennax = zmienna3.ToString();  //konwersja jawna do stringu - ogólnie konwersja to przypisaneie wartośći z innego typu do zmiennej   
            //zmienna2 = Convert.ToByte(zmienna3);
            Console.WriteLine(zmienna4);
            zmienna1 = (int)(zmienna4.Subtract(new DateTime(1970, 1, 1))).TotalSeconds; // 
            Console.WriteLine(zmienna1);

            zmienna4 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(zmienna1);
            Console.WriteLine(zmienna4.ToLocalTime());
            float a = 222.3F; // literał F mówiący, że to float
            Console.WriteLine(a);
            string s1 = "\amyszka \r Mickey \r"; // \r wrzucenie tekstu pomiedzy r na poczatek tekstu zastępując tekst
                                                 // \t to tabulator      \v pionowy znak tabulacji
                                                 // \za pomocą tego możęmy wpisywać apostroft albo inne zakazane znaki
            Console.WriteLine(s1);
            Console.WriteLine(zmienna5 + 5);
        }

        static void operatory()
        {
            zmienna1 = 2;
            zmienna1a = 3;
            string wynik = "";

            //if ((zmienna1 != zmienna1a) || (zmienna1 == 100)) // jeśli warunek jest spełniony to wchodzimy w klamry i wykonuje się instrukcja // || - to jest operator lub
            //{
            //    zmienna1 = 12;
            //}

            //if ((zmienna1 != zmienna1a) && (zmienna1 == 100)) // jeśli warunek jest spełniony to wchodzimy w klamry i wykonuje się instrukcja // && - to jest operator i
            //{
            //    zmienna1 = 12;
            //}

            //if (!(zmienna1 != zmienna1a) && (zmienna1 == 100)) // jeśli warunek jest spełniony to wchodzimy w klamry i wykonuje się instrukcja // && - to jest operator i 
            // możemy dać na początku ! co sprawi, że zaprzeczamy wynikowi zamiast false da true
            //{
            //    zmienna1 = 12;
            //}

            //float var wynik = (float)zmienna1 / zmienna1a;
            //var wynik = zmienna1 % zmienna1a;
            //zmienna1++;
            //ienna1++;
            //ienna1++; // inkrementacja - zwiekszenie w tym przypadku o 1
            //ienna1--; // dekerementacja - zmniejszenie w tym przypadku o 1
            //ienna1 += 2; // inkrementacja - zwiekszenie w tym przypadku o 2

            //zmienna1 += 5; //albo zmienna1 = zmienna1 + 5;
            //zmienna1 *= 5;
            //Console.WriteLine(sizeof(int)); // ilości bitów
            //Console.WriteLine(Int32.MaxValue); // sprawdzanie maksymalnej wartośći danego typu
            //Console.WriteLine(zmienna1a);
            wynik = zmienna1 > 0 ? "Pozytywnie" : zmienna1 < 0 ? "Nie za bardzo" : "Zero"; // ? - operator sprawdzenia wartości
            int a = zmienna1 > 0 ? zmienna1: -100;

            Object obj = new StringReader("Witaj");
            StringReader r = obj as StringReader;

            if (wynik == "Pozytywnie")
            {
                Console.WriteLine("Spełniony");
            }
            else if (wynik == "Zero")
            {
                Console.WriteLine("Wyszło zero");
            }
            else if(wynik == "Nie za bardzo")
            {
                Console.WriteLine("Wyszło nie za bardzo");
            }



            switch(zmienna1)
                {
                case 0:
                    Console.WriteLine("Wyszło 0");
                    break;

                case 1:
                    Console.WriteLine("Wyszło 1");
                    break;

                case 2:
                    Console.WriteLine("Wyszło 2");
                    break;
                default:
                    Console.WriteLine("Wyszło coś tam");
                    break;
            }
            Console.WriteLine(a);
            Console.ReadKey();

            //unsafe
            //{
            //    int* pointer = &numer;
            //    long adres = (long)pointer;
            //    Console.WriteLine($"Adres pamięci mojej zmiennej numer: 0x{adres:X}");
            //}

            //^ to powyźej to użycie niebezpiecznego kodu

        }

       
    }
    
}
