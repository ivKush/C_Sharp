// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ(int a, int b)
{
    if (a > b) return 0;
    return Summ(a + 1, b) + a;
}

System.Console.WriteLine(Summ(int.Parse(Console.ReadLine()),
                              int.Parse(Console.ReadLine())));
