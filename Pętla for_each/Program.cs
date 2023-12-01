using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


//Stwórz projekt w postaci aplikacji konsolowej.

//Wywołaj pętlę foreach na elementach pets = {"cat", "dog", "parrot", "guinea pig"}. Wyświetl elementy w konsoli.
//Jeżeli pętla trafi na element „dog”, niech program wyświetli komunikat „End” i wyjdzie z pętli.

 

//Uwaga 1: rozważ użycie instrukcji break

//Uwaga 2: nie wszystkie elementy zostaną wyświetlone w konsoli, ale możesz zastosować instrukcję continue by to zmienić

namespace Pętla_for_each
{
    internal class Program
    {
        static public void ShowUp()
        {
            List<string> pets = new List<string>(); // utworzyłem listę
            pets.AddRange(new List<string> { "Cat", "Dog", "Parrot", "Guinea Pig" }); // dodałem do listy zwierzęta z zadania
            foreach(string animal in pets) // utworzyłem pętle foreach żeby dla każdego zwierzęcia z listy zostało wykonane wyświetlenie zaś w przypadku psa żeby wypisało end
            {
                if (animal == "Dog")
                {
                    Console.WriteLine("End");
                        continue; // możemy użyć break żeby zakończyć program po wystąpieniu dog, jednak użyłem continue żeby pokazać wszystkie zwierzęta i zamiast dog jest wypisane End żeby pokazać, że działa
                }
                Console.WriteLine(animal);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            ShowUp();
        }
    }
}
