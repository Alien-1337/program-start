using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Korzystając z właściwości kolekcji ArrayList(), napisz program, który do kolekcji tego typu dodaje sześć nazw miast:
//Gdańsk, Warszawa, Katowice, Poznań, Kraków, Rzeszów, a następnie je sortuje alfabetycznie.


namespace ArrayList__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList cities = new ArrayList();
            cities.Add("Gdańsk");
            cities.Add("Warszawa");
            cities.Add("Katowice");
            cities.Add("Poznań");
            cities.Add("Kraków");
            cities.Add("Rzeszów");

            cities.Sort();

            Console.WriteLine("Sorted cities:");
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.ReadLine();
        }
    }
}
