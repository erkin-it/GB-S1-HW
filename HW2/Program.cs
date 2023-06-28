// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Ввод первого числа
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

//Ввод второго числа
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine("Первое число больше второго");
}
else if (b > a) 
{
    Console.WriteLine("Второе число больше первого");
}
else
{
    Console.WriteLine("Оба числа числа равны");
}