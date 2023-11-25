//ID - int
//imię - string
//nazwisko - string
//narodowość - string 
//wiek - byte
//email - string
//płeć - string
//ranking
//zawodowiec/amator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wyścig
{
    internal class Program
    {

        static List<Zawodnik> Zawodnicy = new List<Zawodnik>(); // musimy wpisać static na początku bo main też jest static

        static public int ID { get; set; }
        struct Zawodnik
        {
            public int id, ranking; //public, żeby była widoczna dla całego programy nie tylko w klamrach
            public string imie, nazwisko, narodowosc, email, plec;
            public byte wiek;
            public bool doswiadczenie;

        }
        static void Main(string[] args) // static - w ramach programu będzie tylko jedna kopia takiego programu
        {
 
            int wybor;
           
            do
            {
                WyswietlMenu();

                while (!int.TryParse(Console.ReadLine(), out wybor)
                    || (wybor < 0 || wybor > 5))
                {
                    Console.WriteLine("Dokonoałęś niepoprawnego wyboru," +
                        " wprowadź dane poprawnie");
                }

                switch (wybor)
                {
                    case 1:
                        DodajZawodnika();
                        break;

                    case 2:
                        EdytujZawodnika(1);
                        break;

                    case 3:
                        UsunZawodnika(1);
                        break;

                    case 4:
                        WyswietlZawodnika(1);
                        break;

                    case 5:
                        WyswietlWszystkich();
                        break;
                    default:
                        break;
                }


            } while (wybor != 0);
            ZamknijProgram();

        }

        private static void WyswietlMenu()
        {
            Console.Clear();
            Console.WriteLine("Aplikacja wyscig pokoju Menu:");
            Console.WriteLine("1.Dodawanie Zawodnika");
            Console.WriteLine("2.Edycja Zawodnika");
            Console.WriteLine("3.Usuwanie Zawodnika");
            Console.WriteLine("4.Wyświetl listę zawodników");
            Console.WriteLine("5.Wyświetl wybranego zawodnika");
            Console.WriteLine("0.Zamknij Program");
        }

        static string PodajDane(string daneDoWyswietlenia) {
            Console.Clear();
            Console.WriteLine(daneDoWyswietlenia);
            return Console.ReadLine();
        }


        //Zwróći to co użytkownik wpiszę na klawiaturze
        static void DodajZawodnika() 
        {
            Zawodnik nowy = new Zawodnik();
            nowy.id = ID;
            nowy.imie = PodajDane("Podaj imię: ");
            nowy.nazwisko = PodajDane("Podaj nazwisko ");
            nowy.narodowosc = PodajDane("Podaj narodowść: ");
            nowy.wiek = byte.Parse(PodajDane("Podaj Wiek: "));
            nowy.email = PodajDane("Podaj email: ");
            nowy.plec = PodajDane("Podaj płeć K/M: ").ToUpper();
            nowy.doswiadczenie = PodajDane("Czy jesteś zawodowcem? (T/N)").StartsWith ("T") ? true : false;
            nowy.ranking = int.Parse(PodajDane("Podaj swój ranking: "));
            Zawodnicy.Add(nowy);
            ID++;
        }

        static void UsunZawodnika(int _id) { }

        static void EdytujZawodnika(int _id) { }

        static void WyswietlZawodnika(int _id) { }

        static void WyswietlWszystkich() 
        
        {
            foreach (Zawodnik zaw in Zawodnicy)
            {
                Console.WriteLine($"ID: {zaw.id}, Nazwisko: {zaw.nazwisko}, Imię: {zaw.imie}, ");
            }
        }

        static void ZamknijProgram() { }


    }
}
