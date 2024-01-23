using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który w 100-elementowej tablicy jednowymiarowej umieszcza liczby z przedziału od 1 do 100
//, a następnie sumuje liczby parzyste i nieparzyste należące do tego przedziału.

//Wskazówka: wykorzystaj właściwości pętli foreach.

namespace CollectionItemSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] SwitchElement = new int[100];


            for (int i = 1; i < 100; i++)
            {
                SwitchElement[i] = i + 1;
            }

            int EvenSum = 0;
            int OddSum = 0;

            foreach (int element in SwitchElement)
            {
                if (element %2 == 0)
                {
                    EvenSum += element;
                }

                else
                {
                    OddSum += element;
                }
            }

            Console.WriteLine("Sum of even numbers in array:");
            Console.WriteLine(EvenSum);
            Console.WriteLine("Sum of odd numbers in array:");
            Console.WriteLine(OddSum);
            Console.ReadLine();
        }
    }
}
