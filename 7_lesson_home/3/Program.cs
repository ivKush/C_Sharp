// Задача 3: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

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

void AverageColumn(int[,] arr1)
{
    for (int i = 0; i < arr1.GetLength(1); i++)
    {
        float aver = 0;
        for (int j = 0; j < arr1.GetLength(0); j++)
        {
            aver = arr1[j, i] + aver;
            if (j == arr1.GetLength(0) - 1)
            {
                aver = aver / arr1.GetLength(0);
                Console.Write($"{Math.Round(aver, 1)};  ");
            }
        }
    }
}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
System.Console.WriteLine();
PrintMass(arr1);
System.Console.WriteLine();
AverageColumn(arr1);

