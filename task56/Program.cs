// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}



void MinSumOfRowElemnts(int[,] matrix)
{
    int size = matrix.GetLength(1);
    int indexMinSumOfRowElemnts = 0;
    int[] arrayWithSums = new int[size];

    for (int i = 0; i < size; i++)
    {
        int sum = 0;
        for (int j = 0; j < size; j++)
        {
            sum += matrix[i, j];
        }
        arrayWithSums[i] = sum;
    }

    for (int i = 0; i < arrayWithSums.Length; i++)
    {
        if (arrayWithSums[i] < arrayWithSums[indexMinSumOfRowElemnts]) indexMinSumOfRowElemnts = i;
    }

    Console.WriteLine($"В {indexMinSumOfRowElemnts + 1} строке наименьшая сумма элементов");
}


Console.WriteLine("Массив: ");
Console.WriteLine();
int[,] array2d = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
MinSumOfRowElemnts(array2d);