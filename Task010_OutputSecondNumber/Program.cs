//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Введите трехзначное число ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

if (threeDigitNumber > 99 && threeDigitNumber < 1000)
{
    int result = threeDigitNumber / 10 % 10;
    Console.WriteLine($"{threeDigitNumber} -> {result} - вторая цифра этого числа");
}
else
{
    Console.WriteLine("Вы нарушили запрос");
}
