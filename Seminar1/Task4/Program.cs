// Написать программу, которая на вход принимает число n, а на выходе
// показывает все четные числа от 1 до n
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

for (int i = 2; i <= n; i+= 2)
   Console.Write($"{i} ");

// int i = 2;

// while  (i <= n)
// {
//     Console.Write($"{i} ");
//     i+= 2;
// }