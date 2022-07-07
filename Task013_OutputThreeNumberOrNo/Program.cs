//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine());


if (number > 99 && number < 999)
{
    int result = number % 10;
    Console.WriteLine($"{number} -> {result} - третья цифра этого числа");
}
else
{
    Console.WriteLine($"{number} -> третьей цифры нет у этого числа");
}   

   
//   number = number / 10;

