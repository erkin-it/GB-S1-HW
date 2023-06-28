// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


//Ввод первого числа
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

//Ввод второго числа
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

//Ввод третего числа
Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine());

int MaxNumber = a;

if (b > a) 
{
    MaxNumber = b;
}

if (c > b) 
{
    MaxNumber = c;
}

Console.WriteLine($"Максимальное число: {MaxNumber}");
