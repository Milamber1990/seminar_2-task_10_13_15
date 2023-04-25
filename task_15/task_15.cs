// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру ");
int day = Convert.ToInt32(Console.ReadLine());


{
    if (day > 5 & day < 8)
    Console.Write("YES! Today weekend");

    if (day > 7)
    Console.Write("There is no such day");

    if (day < 6 & day > 0)
    Console.Write("NO! Today is not a day off");
}