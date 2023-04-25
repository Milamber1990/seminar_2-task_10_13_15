Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 100;
Console.WriteLine(num1);

if(num1 == 0)
Console.Write("Третьей цифры нет");

int num2 = num % 100;
Console.Write(num2);