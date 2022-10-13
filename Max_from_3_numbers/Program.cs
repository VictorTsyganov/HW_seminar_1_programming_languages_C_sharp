// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("Введите число 1: ");
int numberone = int.Parse(Console.ReadLine());

Console.Write("Введите число 2: ");
int numbertwo = int.Parse(Console.ReadLine());

Console.Write("Введите число 3: ");
int numberthree = int.Parse(Console.ReadLine());

int max = numberone;

if(max <= numbertwo)
{
    max = numbertwo;
}
if(max <= numberthree)
{
    max = numberthree;
}
Console.Write($"-> {max}");
