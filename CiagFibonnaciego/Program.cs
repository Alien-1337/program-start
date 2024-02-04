using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który rekurencyjnie znajduje 10 pierwszych liczb Fibonacciego* i wyświetla je.

//* Ciąg Fibonacciego to ciąg liczb naturalnych określony rekurencyjnie w następujący sposób:
//pierwszy wyraz to F0 = 0, drugi to F1 = 1, każdy następny jest sumą dwóch poprzednich,
// tzn. Fn-1 + Fn-2 dla n > 1. Wyrazy ciągu Fibonacciego to: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233... itd.

namespace CiagFibonnaciego
{
class Program
        {
            static void Main(string[] args)
            {
                for (int i = 0; i < 10; i++) // W przypadku chęci wyświetlenia więcej liczb limit iteracji można zwiększyć
                {
                    Console.WriteLine($"Fibonacci({i}) = {Fibonacci(i)}");
                }

            Console.ReadLine();
        }

            

            static int Fibonacci(int n)
            {
                if (n <= 1)
                {
                    return n;
                }
                else
                {
                    return Fibonacci(n - 1) + Fibonacci(n - 2);
                }
            }
        }

}


