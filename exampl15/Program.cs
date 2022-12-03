/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели, а мы ответим выходной ли он...");
int nDay = Convert.ToInt32(Console.ReadLine());
if (nDay > 7 || nDay < 1 )
{
    Console.WriteLine("В неделе 7 дней... Введите число от 1 до 7");

}
else
{
    if (nDay < 6)
    {
        Console.WriteLine("нет");
    }

    else
    {
        Console.WriteLine("да");
    }
}
