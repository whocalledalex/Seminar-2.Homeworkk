// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Insert a number that consists of 3 digits: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int result = number / 10 % 10;
// Console.WriteLine(result);



// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Insert a number: ");
string str = Console.ReadLine();
int length = str.Length;
if (length < 3)
{
    Console.WriteLine("There is no third digit");
}
else if (length >= 3)
{
    int result = Convert.ToInt32(str.Substring(0, 3));
    Console.WriteLine(result%10);
}


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Console.WriteLine("Insert a number of the weekday: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 6 || number == 7)
// {
//     Console.WriteLine("This is a weekend");
// }
// else if (number > 7)
// {
//     Console.WriteLine("There is now such a weekday");
// }

// else
// {
//     Console.WriteLine("This is not a weekend");
// }
