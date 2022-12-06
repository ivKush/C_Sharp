// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.

int[] PairsNum(int[] arr)
{
int size = arr.Length;
int flex_size = size / 2 + size % 2;
int[] new_arr = new int[flex_size];

for (int i = 0; i < size / 2; i++)
new_arr[i] = arr[i] * arr[size - i - 1];

if (new_arr[flex_size - 1] == 0)
new_arr[flex_size - 1] = arr[flex_size - 1];
return new_arr;
}
