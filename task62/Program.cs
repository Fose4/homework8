// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;

void FillMatrixSpiral(int[,] matrix)
{
    int n = matrix.GetLength(0);
    int number = 1;
    for (int i = 0; i < n; i++)
    {
        for (int j = i; j < n - i; j++) matrix[i, j] = number++;
        for (int k = i + 1; k < n - i; k++) matrix[k, n - 1 - i] = number++;
        for (int j = n - i - 2; j >= i; j--) matrix[n - 1 - i, j] = number++;
        for (int k = n - 2 - i; k > i; k--) matrix[k, i] = number++;
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine();
    }
}



int[,] array2d = new int[n, n];

FillMatrixSpiral(array2d);
PrintMatrix(array2d);