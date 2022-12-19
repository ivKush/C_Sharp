// https://blog.fenix.help/podgotovka-k-testam-yekzamenam-zachetam/pravilo-umnozheniya-matrits-primery-s-resheniyem

// https://lfirmal.com/matritsyi-chastnyie-vidyi-matrits/#%D0%A3%D0%BC%D0%BD%D0%BE%D0%B6%D0%B5%D0%BD%D0%B8%D0%B5_%D0%BC%D0%B0%D1%82%D1%80%D0%B8%D1%86

// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(5)); // 1 * 2 * 3 = 6

// Фибоначи с рекурсиуй

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}
for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}

// 6.3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.
void Fibbonacci(int num)
{
    int a = 0, b = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
    }
}

int num = int.Parse(Console.ReadLine());
Fibbonacci(num);
