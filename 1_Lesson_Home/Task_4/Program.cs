//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

//Console.Write("Введите число от 1: ");
//int N =int.Parse(Console.ReadLine());

//System.Console.Write("Все чётные числа: ");   
//for (int a=1, b=0; a<=N; a++) 
//{
    //b=a%2;
  //  if (b==0) System.Console.Write($"{a} ");
//}

Console.Write("Введите число: ");

int N = int.Parse(Console.ReadLine());
int a = 1;
while (a<=N) 
{
    if (a % 2 == 0)
    
       Console.Write($"{a} ");
    
    a++;
}