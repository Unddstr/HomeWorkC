// Написать программу, которая на вход принимает два числа и выдает,
// какое число большее, а какое меньшее
Console.Clear();
Console.Write("Введите 1-е число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int b = int.Parse(Console.ReadLine()!);

if (a > b)
{
    Console.Write($"max = {a}\nmin = {b}");
}
else
{
    Console.Write($"max = {b}\nmin = {a}");
}