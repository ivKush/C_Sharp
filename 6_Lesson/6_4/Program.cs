// 4. Напишите программу, которая будет создавать
//    копию заданного массива с помощью поэлементного копирования.


void Print(int[,] arr)
{
    int stolb = arr.GetLength(1);
    int raw = arr.GetLength(0);

    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < stolb; j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
}

int[,] Massiv(int raw, int stolb)
{
    int[,] arr = new int[raw, stolb];

    for (int i = 0; i < raw; i++)
        for (int j = 0; j < stolb; j++)
            arr[i, j] = new Random().Next(100, 1000);
    return arr;
}

int[,] MasClone(int[,] arr_1)
{
    int raw = arr_1.GetLength(0);
    int stolb = arr_1.GetLength(1);
    int[,] new_arr = new int[raw, stolb];
    for (int i = 0; i < raw; i++)
    {
        for (int j = 0; j < stolb; j++)
            new_arr[i, j] = arr_1[i, j];
    }
    return new_arr;
}

int[,] arr_1 = Massiv(int.Parse(Console.ReadLine()),
                     int.Parse(Console.ReadLine()));
System.Console.WriteLine();
Print(arr_1);
int[,] arr_2 = MasClone(arr_1);
System.Console.WriteLine();
Print(arr_2);
System.Console.WriteLine();
