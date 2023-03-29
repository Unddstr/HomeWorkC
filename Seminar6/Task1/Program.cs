// Задача 41. Пользователь ввел с клавиатуры n чисел, посчитать сколько
// введенных чисел > 0?
Console.Clear();
Console.WriteLine("Введите количество чисел: ");
int n = int.Parse(Console.ReadLine()!);
int count = 0;

for (int i = 0; i < n; i++)
{
    int numbers = new Random().Next(-100, 100);
    if(numbers > 0)
    count++;
    Console.Write(numbers + " ");
}
Console.WriteLine();
Console.Write($"Количество положительных чисел = {count}");