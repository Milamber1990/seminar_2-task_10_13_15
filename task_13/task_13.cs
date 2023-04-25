Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ваше число = {num}");


int num6(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}


if (num < 100)
Console.Write("Третьей цифры нет");
else
Console.WriteLine($"Третье число = {num6(num)}");