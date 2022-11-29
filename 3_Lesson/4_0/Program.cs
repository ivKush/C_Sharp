// Задача 3: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void Chet(int N)
{
    int i = 0;
    double pere;
    while (i < N )
    {
        i += 1;
        if (i == (N))
        {
        pere = Math.Pow(i,2);
        Console.Write($"{pere}");
        }
        else
        {

        pere = Math.Pow(i,2);
        Console.Write($"{pere},");
        }
    }
}
Console.WriteLine("введите ч");
int chislo = int.Parse(Console.ReadLine());
Chet(chislo);