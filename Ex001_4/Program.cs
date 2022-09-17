// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1>num2 & num1>num3)
{
    Console.WriteLine($"max = {num1}");
}
    
if(num2>num1 & num2>num3)
{
    Console.WriteLine($"max = {num2}");
}

else 
{
    Console.WriteLine($"max = {num3}");
}