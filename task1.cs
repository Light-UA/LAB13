using System;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо і заповнюємо квадратну матрицю
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Викликаємо метод і виводимо результат на екран
        int diagonalSum = GetDiagonalSum(matrix);
        Console.WriteLine($"Сума елементів головної діагоналі: {diagonalSum}");
    }

    static int GetDiagonalSum(int[,] matrix)
    {
        int sum = 0;
        int size = matrix.GetLength(0); // Отримуємо розмір квадратної матриці

        // Обходимо головну діагональ і додаємо її елементи до суми
        for (int i = 0; i < size; i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }
}
