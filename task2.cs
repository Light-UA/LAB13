using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо і заповнюємо масив числами
        int[] array = { 64, 25, 12, 22, 11 };

        // Виводимо початковий масив на екран
        Console.WriteLine("Початковий масив:");
        PrintArray(array);

        // Викликаємо метод сортування
        SelectionSort(array);

        // Виводимо відсортований масив на екран
        Console.WriteLine("Відсортований масив:");
        PrintArray(array);

        // Очікуємо натискання клавіші перед завершенням програми
        Console.ReadKey();
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        // Перебираємо всі елементи масиву
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            // Знаходимо індекс найменшого елементу у підмасиві
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Міняємо місцями поточний елемент з найменшим елементом
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
