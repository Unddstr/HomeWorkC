// // Написать программу, которая на вход принимает три числа, а на выходе
// // показывает максимальное из этих чисел
Console.Clear();
Console.Write("Введите 1-е число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-е число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;

if (b > max)
{
    max = b;
}
if (c > max)
{ 
    max = c;
}
    Console.Write($"max = {max}");