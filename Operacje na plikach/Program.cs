using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Emit;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który wczytuje z klawiatury tytuł książki oraz nazwisko autora, zapisuje te dane do pliku tekstowego library.txt
//a następnie odczytuje je z pliku library.txt i wyświetla.

namespace Operacje_na_plikach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tytuł książki");
            string book = Console.ReadLine();
            Console.WriteLine("Podaj autora");
            string author = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("library.txt"))
            {
                writer.WriteLine(book);
                writer.WriteLine(author);
            }

            Console.WriteLine("Dane zapisane w pliku");


            Console.WriteLine("Dane w pliku");
            using (StreamReader reader = new StreamReader("library.txt"))
            {
                string loadBook = reader.ReadLine();
                string loadAuthor = reader.ReadLine();

                Console.WriteLine($"Tytuł książki {loadBook}.");
                Console.WriteLine($"Autor książki {loadAuthor}");
            }
            Console.ReadKey();
        }
    }
}
