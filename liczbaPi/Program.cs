using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz program, który za pomocą metody Monte Carlo oblicza liczbę Pi z określoną dokładnością. Skorzystaj z rysunku pomocniczego i następującej listy kroków:

//Wpisz koło o promieniu r w kwadrat o boku 2r

//Losowo wygeneruj punkty i umieść je w kwadracie

//Wyznacz liczbę punktów, które znajdują się jednocześnie w kwadracie i kole

//Niech promień r będzie wyznaczony przez stosunek liczby punktów znajdujących się w kole do liczby punktów znajdujących się w kwadracie

//Pi~4.0·r

//Dodatkowo należy zmierzyć czas obliczeń sekwencyjnych.

///Uwaga 1: im więcej punktów wygeneruje program, tym przybliżenie liczby Pi będzie lepsze, ale wydłuży się czas oczekiwania na wynik

///Uwaga 2: do zliczania czasu warto rozważyć użycie polecenia int start = Environment.TickCount oraz int stop = Environment.TickCount

namespace liczbaPi
{
    internal class Program
    {
        public static void LiczbaPi()
        {
            int numberOfPoints = 1000000; // Zmienna do uzyskania dokładności liczby Pi

            double r = 1.0; // Promień koła
            int pointsInsideCircle = 0;

            // Mierzenie czasu obliczeń
            int start = Environment.TickCount;

            //Monte Carlo
            Random random = new Random();
            for (int i = 0; i < numberOfPoints; i++)
            {
                double x = random.NextDouble() * r; // Generowanie losowej współrzędnej
                double y = random.NextDouble() * r; // Generowanie losowej współrzędnej

                // Sprawdzanie czy punkt należy do koła
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(r, 2)) // ponieważ wzór na koło to x^2 + y^2 = r^2 a my chcemy żeby było poniżej
                {
                    pointsInsideCircle++;
                }
            }

            // Obliczanie przybliżonej wartości liczby Pi
            double piEstimation = 4.0 * pointsInsideCircle / numberOfPoints;

            // Mierzenie czasu obliczeń
            int stop = Environment.TickCount;
            int elapsedTime = stop - start;

            // Wyświetlanie wyników
            Console.WriteLine($"Przybliżona wartość liczby Pi: {piEstimation}");
            Console.WriteLine($"Czas obliczeń: {elapsedTime} ms");

            Console.ReadLine();

        }
    static void Main(string[] args)
        {
            LiczbaPi();
        }
    }
}
