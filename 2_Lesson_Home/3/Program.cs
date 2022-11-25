// Задача 3:
// Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
 
System.Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество цифр из которого состоит число : ");
int b = int.Parse(Console.ReadLine());
//   123456
while  (b>3) 
    {
    a=a/10; 
    b=b-1;
    }
    if (b==2|b==1) 
    System.Console.WriteLine("в числе нет 3 знака");
 else  System.Console.WriteLine(a%10);

