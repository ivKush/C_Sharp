// 2. Напишите программу, которая будет
//    преобразовывать десятичное число в двоичное.

string Bin(int n)
{
    string result = "";

    while (n > 0)
    {
        result = n % 2 + result;
        n /= 2;
    }
    return result;
}

Console.WriteLine(Bin(int.Parse(Console.ReadLine())));


