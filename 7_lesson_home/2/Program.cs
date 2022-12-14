// Задача 2: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] CollMass(int row, int column)
{
    int[,] arr = new int[row, column];
    var rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rand.Next(1, 100);
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
string Itemposi(int[,] arr1, int collRow, int collColumn)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
        for (int j = 0; j < arr1.GetLength(1); j++)
            if (i == collRow - 1 && j == collColumn - 1)
                return $"{arr1[collRow - 1, collColumn - 1]}";
    return $"В данном массиве нет элемента с такой позицией";
}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
PrintMass(arr1);
System.Console.Write("Введите позицию элемента в строке: ");
int collRow = int.Parse(Console.ReadLine());
System.Console.Write("Введите позицию элемента в столбце: ");
int collColumn = int.Parse(Console.ReadLine());
System.Console.WriteLine(Itemposi(arr1, collRow, collColumn));