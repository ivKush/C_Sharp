// 1. Напишите программу, которая принимает
//    на вход число и выдаёт количество цифр в числе.

int Num(int n)
{
    if (n==0)
    return (1);
    int i=0;
    while (n>0)
    {
        n=n/10;
        i++;
    }
    return i;
}
System.Console.WriteLine(Num(int.Parse(Console.ReadLine())));

