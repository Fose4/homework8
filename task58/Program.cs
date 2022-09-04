// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }

    return matrix;
}

void PrintMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrixMultiplication)
{
    Console.WriteLine();

    int size = firstMatrix.GetLength(0) > secondMatrix.GetLength(0) ? firstMatrix.GetLength(0) : secondMatrix.GetLength(0);

    for (int i = 0; i < size; i++)
    {
        if (i < firstMatrix.GetLength(0))
        {
            Console.Write("|");
            for (int j = 0; j < firstMatrix.GetLength(1); j++)
            {
                Console.Write($"{firstMatrix[i, j],3} ");
            }
            Console.Write("|");
        }
        else
        {
            {
                Console.Write(" ");
                for (int j = 0; j < firstMatrix.GetLength(1); j++)
                {
                    Console.Write($"{"",3} ");
                }
                Console.Write(" ");
            }
        }

        Console.Write(" ");
        if (i == 1) Console.Write("X ");
        else Console.Write("  ");


        if (i < secondMatrix.GetLength(0))
        {
            Console.Write("|");
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                Console.Write($"{secondMatrix[i, j],3} ");
            }
            Console.Write("|");

        }
        else
        {
            Console.Write(" ");
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                Console.Write($"{"",3} ");
            }
            Console.Write(" ");
        }

        Console.Write(" ");
        if (i == 1) Console.Write("= ");
        else Console.Write("  ");

        if (i < resultMatrixMultiplication.GetLength(0))
        {
            Console.Write("|");
            for (int j = 0; j < resultMatrixMultiplication.GetLength(1); j++)
            {
                Console.Write($"{resultMatrixMultiplication[i, j],5} ");
            }
            Console.WriteLine("|");

        }
        else { Console.WriteLine(); }


    }
    Console.WriteLine();

}

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int size = firstMatrix.GetLength(0);
    int[,] matrixResult = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i, k] * secondMatrix[k, j];
            }
            matrixResult[i, j] = sum;
        }
    }

    return matrixResult;
}

Random rnd = new Random();
int row = 2;
int colum = 2;


int[,] matrixFir = CreateMatrixRndInt(row, colum, 1, 10);
int[,] matrixSec = CreateMatrixRndInt(colum, row, 1, 10);
int[,] matrixMultiplication = MatrixMultiplication(matrixFir, matrixSec);

PrintMatrixMultiplication(matrixFir, matrixSec, matrixMultiplication);