using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть кількість доданків суми (N):");
        int N = int.Parse(Console.ReadLine());

        // Рекурсивний виклик методу для обчислення суми
        int sumRecursive = CalculateSumRecursive(N);
        Console.WriteLine($"Результат рекурсивного обчислення: {sumRecursive}");

        // Ітераційний виклик методу для обчислення суми
        int sumIterative = CalculateSumIterative(N);
        Console.WriteLine($"Результат ітераційного обчислення: {sumIterative}");

        Console.ReadKey();
    }

    // Рекурсивний метод для обчислення суми
    static int CalculateSumRecursive(int N)
    {
        if (N == 1)
            return 2;
        else
            return (int)Math.Pow(2, N) + CalculateSumRecursive(N - 1);
    }

    // Ітераційний метод для обчислення суми
    static int CalculateSumIterative(int N)
    {
        int sum = 0;
        for (int n = 1; n <= N; n++)
        {
            sum += (int)Math.Pow(2, n);
        }
        return sum;
    }
}
