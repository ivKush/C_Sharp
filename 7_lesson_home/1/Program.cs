// Задача 1: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] TwoCollMass(int row, int column)
{
    double[,] arr = new double[row, column];
    var rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            arr[i, j] = Math.Round(rand.NextDouble() * (10 + 10) - 10, 1);
    }
    return arr;
}

void PrintMass(double[,] arr)
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

double[,] arr1 = TwoCollMass(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
PrintMass(arr1);