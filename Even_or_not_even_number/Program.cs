// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int numberone = int.Parse(Console.ReadLine());

if(numberone % 2 == 0)
{
    Console.Write($"Да. Число {numberone} четное.");
}
else
{
    Console.Write($"Нет. Число {numberone} нечетное.");
}
