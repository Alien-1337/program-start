using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10 × 10 o nazwie macierz umieszcza
//na przekątnej liczby z przedziału od 0 do 9, a poza przekątną 0. Dodatkowo program powinien
//obliczać sumę wyróżnio- nych w tablicy elementów, tzn. elementów znajdujących się na jej przekątnej.

namespace Tablica_Wielowymiarowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[,] tablica2D = new int [size, size];

            for (int i = 0; i < size; i++)
            {
                for (int p = 0; p < size; p++)
                {
                    if (i == p)
                    {
                        tablica2D[i, p] = i % 10;

                    }
                    else
                    {
                        tablica2D[i, p] = 0;
                    }
                }
            }
            Console.Write("Tablica:");
            showTablica2D(tablica2D);

            int sumaPrzekatnej = SumaPrzekatnej(tablica2D);
            Console.WriteLine($"Suma elementów na przekątnej: {sumaPrzekatnej}");
            Console.ReadKey();
        }

        static void showTablica2D(int[,] tablica2D)
        {
            for (int i = 0; i < tablica2D.GetLength(0); i++)
            {
                for (int p = 0; p < tablica2D.GetLength(1); p++)
                {
                    Console.Write("{0}\t", tablica2D[i, p]);
                }
                Console.WriteLine();
            }
        }

        static int SumaPrzekatnej(int[,] tablica2D)
        {
            int suma = 0;
            for (int i = 0; i < tablica2D.GetLength(0); i++)
            {
                suma += tablica2D[i, i];
            }
            return suma;
        }


    }
}
