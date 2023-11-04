

using System.Runtime.CompilerServices;

internal class Program
{

    static int a=0;
    static int b = 0;
    static string? pobrana; // znak zapytania na końcu zmiennej możę również przypisać wartość null
    /// <summary>
    /// Procedura główna aplikacji
    /// </summary>
    /// <param name="args">Parametry wejściowe w postaci tablicy tekstowej</param>
    private static void Main(string[] args)
    {
        try
        {
            // a = a + 1; // albo i += 1
            Console.WriteLine("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine()!);
            //pobrana = Console.ReadLine();

            Console.WriteLine("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine()!);
            //pobrana = Console.ReadLine();
            Console.WriteLine(a + b);
        }

        catch (Exception)
        {
            Console.WriteLine("Stary podałeś coś nie tak");
        }
       

        Console.ReadLine(); //użytkownik musi wpisać coś na klawiaturze
    }

    

}





