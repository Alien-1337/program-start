using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który tablicę o wymiarach 10 × 10 wypełnioną jedynkami zapisuje do pliku tekstowego dane.txt,
//a następnie zapisane dane odczytuje z pliku dane.txt i wyświetla.
//Obsłuż sytuację, w której plik dane.txt nie będzie istniał i w związku z tym jego odczytanie nie będzie możliwe.

namespace ObsługaWyjątków
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tableOne = new int [10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    tableOne[i, j] = 1;
                }
                 ;
            }

            ZapiszDoPliku(tableOne, "data.txt");
            Console.WriteLine("Zapisano dane do pliku");


        }

        static void ZapiszDoPliku(int[,] tableOne, string nazwaPliku)
        {
            using (StreamWriter writer = new StreamWriter(nazwaPliku))
            {
                for (int i = 0; i < tableOne.GetLength(0); i++)
                {
                    for (int j = 0; j < tableOne.GetLength(1); j++)
                    {
                        writer.Write(tableOne[i, j] + " ");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}
