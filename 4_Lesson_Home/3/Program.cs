//   Напишите программу, которая задаёт массив из 8 элементов 
//   случайными числами и выводит их на экран. Оформите заполнение массива и 
//   вывод в виде функции (пригодится в следующих задачах).

int nums = new Random().Next(10000000, 100000000);
//System.Console.WriteLine(nums);
void OutMass(int nums)
{
    int i = 0, n = 0, nums2 = nums;
    while (n < nums)
    {
        nums = nums / 10;
        i++;
    }

    int[] Mass = new int[i];
    for (int z = 0, s = 1; z < nums2; Mass[i - s] = nums2 % 10, nums2 = nums2 / 10, s++) ;

    for (int p = 0; p < Mass.Length; p++)
    {
        Console.Write($"{Mass[p]} ");
    }
}
OutMass(nums);
