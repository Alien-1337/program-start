

using System.Runtime.CompilerServices;

internal class Program
{
    /// <summary>
    /// Procedura główna aplikacji
    /// </summary>
    /// <param name="args">Parametry wejściowe w postaci tablicy tekstowej</param>
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! ");
        Kielbasa();
        Console.ReadLine(); //użytkownik musi wpisać coś na klawiaturze
    }


    private static void Kielbasa()
    {
        Console.WriteLine($"Kielbasa");
    }

}





