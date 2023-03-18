// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N
Console.Clear();
Console.Write("Введите число: ");
int n;
int i;

n = Convert.ToInt32(Console.ReadLine());
i = 1;

// while (i <= n)
// {
//         Console.Write($"{i*i*i} ");
//         i++;
// }

while (i <= n)
{
        Console.Write($"{Math.Pow(i, 3)} ");
        i++;
}
