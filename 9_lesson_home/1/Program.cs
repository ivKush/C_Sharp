// Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void EvenNums(int a)
{
    if (a == 0) return;
    if (a % 2 == 0)
    {
        System.Console.Write($"{a} ");
        EvenNums(a - 2);
    }
    else
    {
        a = a - 1;
        System.Console.Write($"{a} ");
        EvenNums(a - 2);
    }
}

EvenNums(int.Parse(Console.ReadLine()));