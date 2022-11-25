// Задача 4:
// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число");
int y = int.Parse(Console.ReadLine());
if ( y == 1) 
{
    Console.WriteLine("Понедельник");
}
else if (y == 2)
{
    Console.WriteLine("Вторник");
}
else if (y == 3)
{
    Console.WriteLine("Cреда");
}
else if (y == 4)
{
    Console.WriteLine("Четверг");
}
else if (y == 5)
{
    Console.WriteLine("Пятница");
}
else if (y == 6)
{
    Console.Write("Суббота");
}
else if (y == 7)
{
    Console.Write("Воскресенье");
}
else
{
    Console.WriteLine("error");
}

if (y==6|y==7)
{
    System.Console.Write(" - Выходной");
}


