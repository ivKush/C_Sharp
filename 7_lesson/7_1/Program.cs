// 2. Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.

int[,] FillArray(int rows, int columns)
{
int[,] arr = new int[rows, columns];

for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
arr[i, j] = i+j;
}
return arr;
}

void PrintArray(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
Console.Write($"{arr[i, j], 6} ");
Console.WriteLine();
}
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine()!);

int[,] arr_1 = FillArray(row, column);

PrintArray(arr_1);