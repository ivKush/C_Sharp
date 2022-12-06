//    Напишите программу замена элементов массива:
//    положительные элементы замените на соответствующие отрицательные, и наоборот.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] Mass(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(-100, 100);
    return arr;
}

void Massiv(int[] arr_1)
{
    for (int i = 0;i < arr_1.Length; i++)
        arr_1[i] = -arr_1[i];

}

int[] arr_1 = Mass(int.Parse(Console.ReadLine()));
Print(arr_1);
Massiv(arr_1);
Print(arr_1);

