using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Dane są dwie macierze 10 × 10 o nazwach a i b.

//W macierzy A mamy same jedynki, w macierzy B mamy same dwójki, utwórz macierze C i dodaj A+B


namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] FirstMatriceA = new int [10, 10];
            int[,] SecondMatriceB = new int[10, 10];
            int[,] ThirdMatriceC = new int[10, 10];
            //używamy i oraz j z racji, żę i reprezentuje nam wiersz a j kolumnę w macierzy
            for (int i = 0; i < 10; i++ )
            {
                for (int j = 0; j < 10; j++)
                {
                    FirstMatriceA[i, j] = 1;
                }
                
             }
            //Powtarzamy zabieg dla drugiej macierzy
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    SecondMatriceB[i, j] = 2;
                }
            }
            //Teraz dodajemy w macierzy C, obie macierze (A i B) dodając wiersze i kolumny
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ThirdMatriceC[i, j] = FirstMatriceA[i,j] + SecondMatriceB[i,j];
                }
            }

            //Wyświetlimy teraz macierz C
            Console.WriteLine("Wynikowa macierzy to:");
            Console.WriteLine("\t");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine(ThirdMatriceC[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
