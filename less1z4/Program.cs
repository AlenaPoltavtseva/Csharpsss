﻿Console.WriteLine("Введите трёхзначное число");
int num = int.Parse(Console.ReadLine());

if (num < 1000 && num > 99) 
{
    int result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Нельзя такое число");
}