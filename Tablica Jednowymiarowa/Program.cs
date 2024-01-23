using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica_Jednowymiarowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int[] tablica1 = new int[10];

                // Wypełnij tablicę indeksami
                for (int i = 0; i < tablica1.Length; i++)
                {
                    tablica1[i] = i;
                }

                // Wyświetl indeksy i przypisane wartości w konsoli
                Console.WriteLine("Indeks | Wartość");
                Console.WriteLine("----------------");

            for (int i = 0; i < tablica1.Length; i++)
            {
                Console.WriteLine($"{i,-6}| {tablica1[i], +3}");
            }
                Console.ReadLine();
        }

    }
}

