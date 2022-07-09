//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine());

//while (number > 999)
//{
//    number = number / 10;
//}

//if (number > 99 && number < 999)
//{
//    int result = number % 10;
//    Console.WriteLine(result + " - третья цифра этого числа");
//}
//else
//{
//    Console.WriteLine("третьей цифры нет у этого числа");
//}

if (number < 99)
{
    Console.WriteLine("третьей цифры нет у этого числа");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine(result + " - третья цифра этого числа");
}
