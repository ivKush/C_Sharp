
// string Metod4(int count, string text)
// {
// int i = 0;
// string result = String.Empty;
// while (i<count)
// {
// result = result + text;
// i++;
// }
// return result;
// }
// string res = Metod4(10, "Z");
// Console.WriteLine(res);

int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}