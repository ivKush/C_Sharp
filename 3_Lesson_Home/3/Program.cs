// 3_Lesson_Home_1
 System.Console.WriteLine("Ввведите пятизначное число");
    var empty = Console.ReadLine();
    int number = empty == null ? 0 : int.Parse(empty);

string palindrome( string a)
{
   
    //string a;
    if (number > 99999 || number < 10000)
    {
        a = "Error";
    }
        if (number % 10 == number / 10000)
        {
        a = "ДА";
        }
        if ((number / 10) % 10 == (number / 1000) % 10)
        {
        a = "ДА";
        }
        else a = "НЕТ";
    
    return a;
}
palindrome(number, a);
//System.Console.WriteLine(palindrome);