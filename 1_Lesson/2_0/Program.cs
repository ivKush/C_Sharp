// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    являетcя ли первое число квадраом второго


Console.WriteLine("Введите число 1");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2");
int num2 = int.Parse(Console.ReadLine());

if(num2 == num1*num1)
{
    Console.WriteLine("да");
}

else 
    Console.WriteLine("нет");
