// https://blog.fenix.help/podgotovka-k-testam-yekzamenam-zachetam/pravilo-umnozheniya-matrits-primery-s-resheniyem

// https://lfirmal.com/matritsyi-chastnyie-vidyi-matrits/#%D0%A3%D0%BC%D0%BD%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86

// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            System.Console.Write($"{arr[i, j]}   ");
        }
        System.Console.WriteLine();
    }
}


int[,] Matrix2(int[,] arr1, int[,] arr2)
{
    int rowSize = arr1.GetLength(0);
    int columnSize = arr1.GetLength(1);
    int[,] multMatrix = new int[rowSize, columnSize];

    if (rowSize != arr2.GetLength(0) || columnSize != arr2.GetLength(1)) return multMatrix;

    for (int i = 0; i < rowSize; i++)
    {
        for (int j = 0; j < columnSize; j++)
        {
            multMatrix[i, j] = arr1[i, j] * arr2[i, j];
        }
    }
    return multMatrix;
}

int[,] arr1 = CollMass(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
int[,] arr2 = CollMass(int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
System.Console.WriteLine();
PrintMass(arr1);
System.Console.WriteLine();
PrintMass(arr2);
System.Console.WriteLine();
PrintMass(Matrix2(arr1, arr2));

