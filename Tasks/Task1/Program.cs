Console.WriteLine("Введите число: ");
string s = Console.ReadLine();
int len = s.Length;

if (len == 5)
{
    if (s[0] == s[4] && s[1] == s[3])
    {
        Console.WriteLine($"{s} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{s} - Не палиндром");
    }
}
else
{
    Console.WriteLine("Введенное число не является пятизначным");
}
