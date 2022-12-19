// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CollMass(int row, int column)
{
    int[,] arr = new int[row, column];
    var rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rand.Next(0, 10);
        }
    }
    return arr;
}

void PrintMass(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]}  ");
        }
        System.Console.WriteLine();
    }
}

void ArrangeLine(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int maxItem = arr[i, 0];
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > maxItem)
            {
                maxItem = arr[i, j];
                (arr[i, 0], arr[i, j]) = (arr[i, j], arr[i, 0]);
            }
            // if (maxItem > arr[i])
        }
    }
}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMass(arr1);
System.Console.WriteLine();
ArrangeLine(arr1);
PrintMass(arr1);