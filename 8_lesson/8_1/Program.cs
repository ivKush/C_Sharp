// 1. Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int[,] CollMass(int row, int column)
{
    int[,] arr = new int[row, column];
    var rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rand.Next(1, 10);
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

void ReversRow(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    for (int i = 0; i < column; i++)
        (arr[0, i], arr[row - 1, i]) = (arr[row - 1, i], arr[0, i]);
}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
System.Console.WriteLine();
PrintMass(arr1);
System.Console.WriteLine();
ReversRow(arr1);
PrintMass(arr1);
