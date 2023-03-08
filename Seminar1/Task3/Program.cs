// // Написать программу, которая на вход принимает число, а на выходе 
// // показывается является ли число четным?
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int kratnost = 2;
if (n % kratnost == 0)
{
    Console.Write("Да");
}
else
{
     Console.Write("Нет");
}