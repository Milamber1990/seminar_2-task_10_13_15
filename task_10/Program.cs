Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 100;
int num2 = (num / 10) % 10;
int num3 = num % 10;


if(num1 > 9 | num1 == 0)
Console.WriteLine("ОШИБКА!!! Вы ввели не трехзначное число");
else
Console.Write($"Число в середине {num2}");

