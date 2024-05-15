using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо масиви для тестування
        double[] numbers = { 1.1, 2.2, 3.3, 4.4, 5.5 };
        string[] слова = { "яблуко", "банан", "апельсин", "виноград", "ківі" };

        // Запитуємо користувача про значення для пошуку
        Console.WriteLine("Введіть число для пошуку:");
        double numberToSearch = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть слово для пошуку:");
        string wordToSearch = Console.ReadLine();

        // Викликаємо методи пошуку та виводимо результати
        bool numberFound = Search(numbers, numberToSearch);
        bool wordFound = Search(слова, wordToSearch);

        Console.WriteLine($"Число знайдено: {numberFound}");
        Console.WriteLine($"Слово знайдено: {wordFound}");

        Console.ReadKey();
    }

    // Перевантажений метод для бінарного пошуку числа у масиві double
    static bool Search(double[] array, double target)
    {
        Array.Sort(array);
        int left = 0;
        int right = array.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (array[mid] == target)
                return true;

            if (array[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }

        return false;
    }

    // Перевантажений метод для послідовного пошуку слова у масиві string
    static bool Search(string[] array, string target)
    {
        foreach (string word in array)
        {
            if (word == target)
                return true;
        }

        return false;
    }
}
