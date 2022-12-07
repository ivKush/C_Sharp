
// Задача 3: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.

// [3, 7, 22, 2, 78] -> 76

void PrintMass(double[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]}  ");
    Console.WriteLine();
}

double[] CollMass(int size)
{
    double[] arr = new double[size];
    var rand = new Random();

    for (int i = 0; i < size; i++)
        arr[i] = Math.Round((rand.NextDouble() * (100 + 100) - 100), 2);
    return arr;
}

void Diff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    double diff = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    diff = max - min;
    diff = Math.Round(diff, 2);
    //Math.Round((diff = max - min), 2);
    System.Console.WriteLine($"({max}) - ({min}) = {diff}");
}
double[] ready = CollMass(int.Parse(Console.ReadLine()));
PrintMass(ready);
Diff(ready);

