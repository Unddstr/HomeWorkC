// Напишите программу, которая на вход принимает цифру, обозначающую день 
// недели, а на выходе показывает является ли этот день выходным
Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int n = int.Parse(Console.ReadLine()!);

while (n < 1 || n > 7)
{
    Console.Write("Неверно введен день недели! \nПовторите ввод: ");
    n = int.Parse(Console.ReadLine()!);
}

if (n <= 5)
    Console.WriteLine($"Введенный день {n} - Будний день");
else
    Console.WriteLine($"Введенный день {n} - Выходной день");
