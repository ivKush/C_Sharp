// Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

string divisible(int num)
{
    if (num % 7 == 0 && num % 23 == 0)
        return "divisible";
    else
        return "non-divisible";
}
Console.WriteLine("enter number");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(divisible(number));

