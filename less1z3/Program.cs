﻿Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

for(int i= -n; i <=n; i++)
{ 
    Console.Write(i);
    Console.Write(", ");
}
// с введением -n не работает