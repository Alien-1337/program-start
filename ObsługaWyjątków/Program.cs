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
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "dane.txt";

            // Tworzenie tablicy 10x10 wypełnionej jedynkami
            int[,] array = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = 1;
                }
            }

            // Zapisywanie tablicy do pliku
            SaveArrayToFile(fileName, array);

            // Odczytywanie tablicy z pliku i wyświetlanie
            try
            {
                int[,] newArray = LoadArrayFromFile(fileName);
                DisplayArray(newArray);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Plik {0} nie istnieje.", fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd podczas odczytu danych: {0}", ex.Message);
            }
        }

        static void SaveArrayToFile(string fileName, int[,] array)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        writer.Write(array[i, j]);
                        if (j < 9)
                            writer.Write(" ");
                    }
                    writer.WriteLine();
                }
            }
        }

        static int[,] LoadArrayFromFile(string fileName)
        {
            int[,] newArray = new int[10, 10];
            using (StreamReader reader = new StreamReader(fileName))
            {
                for (int i = 0; i < 10; i++)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split(' ');
                    for (int j = 0; j < 10; j++)
                    {
                        newArray[i, j] = int.Parse(parts[j]);
                    }
                }
            }
            return newArray;
        }

        static void DisplayArray(int[,] array)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(array[i, j]);
                    if (j < 9)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
