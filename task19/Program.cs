// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
string numberA = Console.ReadLine();

int numberB = Convert.ToInt32(numberA);

numberA.Length.ToString();

if (numberB > 9999 && numberB < 100000)
{
    Console.Write("Это полиндром? ");

    if (numberA[0] == numberA[4] && numberA[1] == numberA[3])
    {
        Console.WriteLine("да ");
    }
    else
    {
        Console.WriteLine("нет");
    }
}
else Console.WriteLine("Bad number");

