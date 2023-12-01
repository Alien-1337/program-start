using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Stwórz projekt w postaci aplikacji konsolowej.

//Napisz aplikację z zastosowaniem pętli while, która będzie pobiera wartości liczbowe od użytkownika w zakresie 0-10,
//dopóki nie poda on wartości 5. Po wpisaniu przez użytkownika wartości 5, aplikacja powinna:

//obliczyć sumę wszystkich elementów podniesioną do kwadratu

//znaleźć najmniejszy element (minimum)

//Wyniki obliczeń wypisz w konsoli.

namespace Pętla_While
{
    internal class Program
    {
        public static void PetlaWhile()
        {
            List<double> values = new List<double>(); // tworzymy listę która przechowuje dane typu double i nazywa się values
            
            while (true)
            {
                Console.WriteLine("Podaj liczbę z przedziału 0-10, podanie liczby 5 zakończy program");
                if (double.TryParse(Console.ReadLine(), out double userInput)) // zamienia wpis użytkownika na double i jeśli true to to co użytkownik wpiszę wyoutuje nam do zmiennej userInput, która będzie używana dalej w programie
                {
                    if (userInput >= 0 && userInput <= 10) // musi zostać spełniony warunek podania liczby z zakresu od 0-10
                    {
                        if (userInput == 5) // tutaj sprawdzamy czy użytkownik wpisał 5
                        {
                            break; // jeśli wpisał to musimy zakończyć program
                        }
                        else
                        {
                            values.Add(userInput); // jeśli wpisał coś innego to dodajemy wpisaną liczbę do wcześniej utworzonej listy o nazwie "values"
                        }

                    }
                    else 
                    { 
                        Console.WriteLine("Wprowadź liczbę z zakresu 0-10"); // jeśli użytkownik wpiszę liczbę z poza zakresu to wyskoczy mu error, żeby wpisał poprawną liczbę
                    }
                }
                else 
                { 
                    Console.WriteLine("Nieprawidłowy format liczby"); // jeśli użytkownik wpiszę niepoprawny format liczby też powinień wyskoczyć error
                }
                if (values.Count > 0) // sprawdzamy czy ilość indeksów w liście jest więcej niż 0
                {
                    double squares = 0; // tworzymy zmienną, którą przechowuje nam kwadrat sumy liczb
                    double minValue = values[0]; // tworzymy zmienną, która przechowuje nam najniższą wartość
                    foreach (int value in values) // foreach będzie wykonywał pętle dla wszystkich elementów listy
                    {
                        squares += Math.Pow(value, 2); // dodajemy wartości do zmiennej squares poprzez metodę Math.Pow gdzie podajemy dwie wartości (1- liczba, 2-moc) w tym wypadku liczba to podana value a moc to 2 bo chcemy dać liczbę do kwadratu
                        if (value < minValue) // sprawdzamy czy podana wartość przez użytkownika jest mniejsza niż minValue na ten moment jeśli tak to zmieniamy minValue na nową wartość
                        {
                            minValue = value;
                        }
                    }
                    Console.WriteLine($"Suma kwadratów wszystkich elementów: {squares}"); // $ przed stringiem czyli string interpolarny możemy wpleść zmienną bez użycia konkatenacji
                    Console.WriteLine($"Najniższa wartość to: {minValue}"); 
                }
                else { Console.WriteLine("Nie wprowadzono nic");
                }
            }
        }
        static void Main(string[] args)
        {
            PetlaWhile();
        }
    }
}