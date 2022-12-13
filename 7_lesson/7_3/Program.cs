
// 3. Задайте двумерный массив. Найдите сумму элементов главной диагонали.

// https://ru.wikipedia.org/wiki/%D0%93%D0%BB%D0%B0%D0%B2%D0%BD%D0%B0%D1%8F_%D0%B4%D0%B8%D0%B0%D0%B3%D0%BE%D0%BD%D0%B0%D0%BB%D1%8C

// https://4apple.org/summa-diagonalnyh-jelementov-matricy/

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int Summ(int[,] arr)
{
    int sum = 0;
    int row = arr.GetLength(0);
    for (int i = 0; i < row; i++)
        sum += arr[i, i];

    return sum;

}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
System.Console.WriteLine(Summ(arr_1));


// int Summ(int[,] arr)
// {
//     int sum = 0;
//     int row = arr.GetLength(0);
//     int column = arr.GetLength(1);
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < column; j++)
//             if (i == j)
//             {
//                 sum += arr[i, j];
//             }

//     }
// }
// Console.Write("Enter the number of rows: ");
// int row = int.Parse(Console.ReadLine());
// Console.Write("Enter the number of columns: ");
// int column = int.Parse(Console.ReadLine());

// int[,] arr_1 = MassNums(row, column,
// int.Parse(Console.ReadLine()),
// int.Parse(Console.ReadLine()));
// Print(arr_1);
// Console.WriteLine(Summ(arr_1));