Console.WriteLine("Введите пятизначное число: "); // Ввод
string num = Console.ReadLine();

if (num.Length == 5)
{
    if (num[0] == num[4] && num[1] == num[3]) // Проверка числа на палиндром
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    Console.WriteLine("Число не является пятизначным");
}