// 4. Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

int[,] arr = new int[4, 4];
arr = DNPTools.FillIntMatrix(arr, 0, 9);

DNPTools.PrintArr(arr);

(int, int) minIndex = (0, 0);
for (int i = 0; i < arr.GetLength(0); i++)
for (int j = 0; j < arr.GetLength(1); j++)
if (arr[minIndex.Item1, minIndex.Item2] > arr[i, j]) minIndex = (i, j);
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
if (i == minIndex.Item1 | j == minIndex.Item2) continue;
Console.Write($"{arr[i, j]} ");
}
Console.WriteLine();
}