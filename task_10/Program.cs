﻿Console.Write("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num / 100;
int num2 = (num / 10) % 10;
int num3 = num % 10;

Console.Write($"Число в середине {num2}")$