// Напишите программу, которая на вход принимает цифру, обозначающую день 
// недели, а на выходе показывает является ли этот день выходным
Console.Clear();
Console.Write("Введите цифру, обозначающую день недели: ");
int n = int.Parse(Console.ReadLine()!);

if (n > 0 && n <= 7 )
{
    if (n <= 5)
    Console.WriteLine("Будний день");
    else 
    Console.WriteLine("Выходной день");
}
else 
Console.WriteLine("Неверно введен день недели, повторите ");
