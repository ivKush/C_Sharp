// 2. Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

// https://ru.wikihow.com/%D1%82%D1%80%D0%B0%D0%BD%D1%81%D0%BF%D0%BE%D0%BD%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D1%82%D1%8C-%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86%D1%83
// https://stepik.org/lesson/416754/step/1?unit=406262

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

void ChangeUp(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    if (row == column)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < i; j++)
            {
                (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
            }
        }
        return;
    }
    Console.WriteLine("Замена невозможна");


}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Console.WriteLine();
PrintMass(arr1);
Console.WriteLine();
ChangeUp(arr1);
PrintMass(arr1);
// ChangeUp нужно переделать с void на возвращающий, чтоб при невозможности замены не дублировался массив.
