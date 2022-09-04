// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int x = 2;
int y = 2;
int z = 2;

int[,,] CreateArray3DRndInt(int size1,int size2,int size3)
{
    Random rnd = new Random();

    int[,,] array3D = new int[size1, size2, size3];
    int[] fillingArray = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int count = 0;

    fillingArray[0] = rnd.Next(10, 100);

    for (int i = 1; i < fillingArray.Length; i++)
    {
        fillingArray[i] = rnd.Next(10, 100);
        for (int j = 0; j < i; j++)
        {
            while (fillingArray[i] == fillingArray[j])
            {
                fillingArray[i] = rnd.Next(10, 100);
                j = 0;
            }
        }

    }

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = fillingArray[count];
                count++;
            }
        }
    }

    return array3D;
}

void PrintArray3D(int[,,] array3D)
{
    for (int k = 0; k < array3D.GetLength(2); k++)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
                Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] array3d = CreateArray3DRndInt(x,y,z);

PrintArray3D(array3d);