﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

//Ввод числа
Console.Write("Введите число больше 2-х : ");
int a = int.Parse(Console.ReadLine());

//переменная вывода четных чисел
int i = 2;

if (a >= 2)
{
    do 
    {
        Console.Write($"{i} ");
        i+=2;
    }
    while (i <= a);
} 
else
{
    Console.WriteLine("Вы ввели число меньшее 2-х");
}
