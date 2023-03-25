// Вася и английский
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

int ChetDays(int[] array)
{
    int countChet = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countChet++;
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine(" ");
    return countChet;
}
int NeChetDays(int[] array)
{
    int countNeChet = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 1)
        {
            countNeChet++;
            Console.Write(array[i] + " ");
        }
    }
    Console.WriteLine(" ");
    return countNeChet;
}

Console.Write("Сколько занятий посетил Вася? - ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

if (ChetDays(array) > NeChetDays(array))
    Console.WriteLine("Получит Вася 4? - Yes");
else
Console.WriteLine("Получит Вася 4? - No");