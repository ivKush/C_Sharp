// 3. Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз
// встречается элемент входных данных. Значения элементов массива 0..9

// https://metanit.com/sharp/tutorial/4.9.php

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

void PrintMass1(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        System.Console.WriteLine($"{i} meets: {arr[i]}");
    System.Console.WriteLine();
}

int[] FrequencyDict(int[,] arr)
{
    int[] freq = new int[10];

    foreach (int item in arr)
        freq[item] += 1;

    return freq;
}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Console.WriteLine();
PrintMass(arr1);
Console.WriteLine();
int[] mass = FrequencyDict(arr1);
PrintMass1(mass);
