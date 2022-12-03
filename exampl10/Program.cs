/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int number = new Random().Next(100, 1000); 
Console.WriteLine("Сгенерированное число: " + number);

int secondDigit = number/10;
secondDigit = secondDigit % 10;

// int max = firstDigit;
// if (secondDigit > max)
// {
//     max = secondDigit;
// }

Console.WriteLine("Вторая цифра: " + secondDigit);