// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CollMass(int row, int column)
{
    int[,] arr = new int[row, column];
    var rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = rand.Next(-20, 20);
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

void PrintMass1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        System.Console.WriteLine($"{arr[i]}  ");
}

int[] MinSumm(int[,] arr)
{
    int[] arr2 = new int[arr.GetLength(0)];
    int summ;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        summ = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            //summ = arr[i, j] + summ;
            summ += arr[i, j];
        }
        arr2[i] = summ;
    }
    return arr2;
}

void MinLine(int[] arr)
{
    int min = arr[0];
    int minline = 1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minline = i + 1;
        }
    }
    System.Console.WriteLine($"Строка с мин.суммой --> {minline}");
    System.Console.WriteLine();
}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
System.Console.WriteLine();
PrintMass(arr1);
System.Console.WriteLine();
int[] arr2 = MinSumm(arr1);
PrintMass1(arr2);
System.Console.WriteLine();
MinLine(arr2);

