// Задача 2: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

// [3, 7, 23, 12] -> 26
// [-4, -6, 4, 67] -> 0

void PrintMass(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] CollMass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(1, 10);
    return arr;
}

int NegPosSumm(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; sum = arr[i] + sum, i += 2) ;
    return sum;
}

int[] ready = CollMass(int.Parse(Console.ReadLine()));
PrintMass(ready);
System.Console.WriteLine(NegPosSumm(ready));

