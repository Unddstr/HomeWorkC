// Написать цикл, который принимает на вход 2 числа a, b и возводит число а
// в натуральную степень b
Console.Clear();
Console.WriteLine("Введите число а: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);
int result = 1;

for (int i = 0; i < b; i++)
{
result = result * a;
}
Console.WriteLine(result);