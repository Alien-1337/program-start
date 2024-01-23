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

        static void UsunZawodnika(int _id) 
        {
            int idDoUsuniecia;
            WyswietlWszystkich();
            Console.Write("Podaj ID zawodnika do usunięcia: ");
            while (!int.TryParse(Console.ReadLine(), out idDoUsuniecia) || !Zawodnicy.Exists(z => z.id == idDoUsuniecia))
            {
                Console.WriteLine("Niepoprawne ID. Spróbuj ponownie.");
            }

            Zawodnicy.RemoveAll(z => z.id == idDoUsuniecia);
            Console.WriteLine($"Zawodnik o ID {idDoUsuniecia} został usunięty.");
        }


        static void EdytujZawodnika(int _id) 
        {
            int idDoEdycji;
            WyswietlWszystkich();
            Console.Write("Podaj ID zawodnika do edycji: ");
            while (!int.TryParse(Console.ReadLine(), out idDoEdycji) || !Zawodnicy.Exists(z => z.id == idDoEdycji))
            {
                Console.WriteLine("Niepoprawne ID. Spróbuj ponownie.");
            }

            Zawodnik zawodnikDoEdycji = Zawodnicy.Find(z => z.id == idDoEdycji);

            Console.WriteLine($"Edytujesz zawodnika o ID {idDoEdycji}.");

            zawodnikDoEdycji.imie = PodajDane($"Nowe imię ({zawodnikDoEdycji.imie}): ");
            zawodnikDoEdycji.nazwisko = PodajDane($"Nowe nazwisko ({zawodnikDoEdycji.nazwisko}): ");
            zawodnikDoEdycji.narodowosc = PodajDane($"Nowa narodowość ({zawodnikDoEdycji.narodowosc}): ");
            byte nowyWiek;
            while (!byte.TryParse(PodajDane($"Nowy wiek ({zawodnikDoEdycji.wiek}): "), out nowyWiek))
            {
                Console.WriteLine("Niepoprawny wiek. Spróbuj ponownie.");
            }
            zawodnikDoEdycji.wiek = nowyWiek;

            zawodnikDoEdycji.email = PodajDane($"Nowy email ({zawodnikDoEdycji.email}): ");
            zawodnikDoEdycji.plec = PodajDane($"Nowa płeć ({zawodnikDoEdycji.plec}): ").ToUpper();
            bool noweDoswiadczenie;
            while (!bool.TryParse(PodajDane($"Nowe doświadczenie ({zawodnikDoEdycji.doswiadczenie}): "), out noweDoswiadczenie))
            {
                Console.WriteLine("Niepoprawna wartość doświadczenia. Spróbuj ponownie.");
            }
            zawodnikDoEdycji.doswiadczenie = noweDoswiadczenie;

            int nowyRanking;
            while (!int.TryParse(PodajDane($"Nowy ranking ({zawodnikDoEdycji.ranking}): "), out nowyRanking))
            {
                Console.WriteLine("Niepoprawny ranking. Spróbuj ponownie.");
            }
            zawodnikDoEdycji.ranking = nowyRanking;

            Console.WriteLine($"Zawodnik o ID {idDoEdycji} został zaktualizowany.");
        }

        static void WyswietlZawodnika(int _id) 
        {
            int idDoWyswietlenia;
            WyswietlWszystkich();
            Console.Write("Podaj ID zawodnika do wyświetlenia: ");
            while (!int.TryParse(Console.ReadLine(), out idDoWyswietlenia) || !Zawodnicy.Exists(z => z.id == idDoWyswietlenia))
            {
                Console.WriteLine("Niepoprawne ID. Spróbuj ponownie.");
            }

            Zawodnik zawodnik = Zawodnicy.Find(z => z.id == idDoWyswietlenia);
            Console.WriteLine($"Dane zawodnika o ID {idDoWyswietlenia}:");

            Console.WriteLine($"ID: {zawodnik.id}");
            Console.WriteLine($"Imię: {zawodnik.imie}");
            Console.WriteLine($"Nazwisko: {zawodnik.nazwisko}");
            Console.WriteLine($"Narodowość: {zawodnik.narodowosc}");
            Console.WriteLine($"Wiek: {zawodnik.wiek}");
            Console.WriteLine($"Email: {zawodnik.email}");
            Console.WriteLine($"Płeć: {zawodnik.plec}");
            Console.WriteLine($"Doświadczenie: {zawodnik.doswiadczenie}");
            Console.WriteLine($"Ranking: {zawodnik.ranking}");
        }

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
