using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Ścieżka do pliku tekstowego, który chcesz przeczytać
        string filePath = "C:/test/test_kon_rad.txt";

        try
        {
            // Odczytaj całą zawartość pliku do ciągu tekstowego
            string fileContent = File.ReadAllText(filePath);

            // Inicjalizacja licznika liter "a"
            int letterACount = 0;

            // Iteruj przez każdy znak w ciągu tekstowym
            foreach (char character in fileContent)
            {
                // Jeśli znak to 'a' (zarówno mała, jak i duża litera)
                if (character == 'a' || character == 'A')
                {
                    // Zwiększ licznik wystąpień litery "a"
                    letterACount++;
                }
            }

            // Wyświetl wynik
            Console.WriteLine($"Ilość wystąpień litery 'a' w pliku: {letterACount}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Plik nie został znaleziony.");
        }
        catch (IOException)
        {
            Console.WriteLine("Wystąpił błąd wejścia/wyjścia podczas odczytu pliku.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił nieoczekiwany błąd: {ex.Message}");
        }
    }
}
