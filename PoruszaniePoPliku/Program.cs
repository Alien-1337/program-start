using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Utwórz plik "biodata.txt" i zapisz do niego tekst „Sekwencja kwasów nukleinowych: 5 - AATTGGCC - 3".
//Odczytaj plik w taki sposób, by w konsoli wydrukować tylko samą sekwencję: 5-AATTGGCC-3." +
//" Użyj funkcji Seek(), aby przejść do odpowiedniego bajtu pliku. Na koniec wyczyść konsolę, usuwając plik.

namespace PoruszaniePoPliku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter("biodata.txt"))
            {
                writer.WriteLine("Sekwencja kwasów nukleinowych: 5 - AATTGGCC - 3");
            }

            Console.WriteLine("Dane zapisane w pliku");

            using (FileStream fileStream = new FileStream("biodata.txt", FileMode.Open, FileAccess.Read))
            {
                fileStream.Seek(32, SeekOrigin.Begin); // Przesunięcie o 32 bajty (w celu pominięcia tekstu początkowego)

                byte[] sequenceBytes = new byte[12]; // 12 bajtów to rozmiar sekwencji "5-AATTGGCC-3"
                int bytesRead = fileStream.Read(sequenceBytes, 0, sequenceBytes.Length);

                string sequence = Encoding.UTF8.GetString(sequenceBytes, 0, bytesRead);
                Console.WriteLine($"Odczytana sekwencja: {sequence}");
            }

            // Usuwanie pliku (jeśli istnieje)
            if (File.Exists("biodata.txt"))
            {
                File.Delete("biodata.txt");
                Console.WriteLine("Plik 'biodata.txt' został usunięty.");
            }
            else
            {
                Console.WriteLine("Plik 'biodata.txt' nie istnieje.");
            }

            Console.ReadKey(); // Zatrzymuje konsolę
        }
    }
}