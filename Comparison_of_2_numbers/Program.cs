// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите число 1: ");
int numberone = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int numbertwo = int.Parse(Console.ReadLine());

int max = 0;

if(numberone >= numbertwo)
{
    max = numberone;
}
else
{
    max = numbertwo;
}

Console.Write($"max = {max}");