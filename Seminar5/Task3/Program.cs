// Задайте массив дробных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3,01 7,23 22,79 2,38 78,45] -> 76,07
void InputArray(double[] array)
{
    for (int i = 0; i< array.Length; i++)
    array[i] = Math.Round(new Random().NextDouble()*100, 2);
}

double Result(double[] array)
{
    double maxNumber = array[0];
    double minNumber = array[0];
    double subtraction = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNumber)
        maxNumber = array[i];
        if (array[i] < minNumber)
        minNumber = array[i];
    }
    subtraction = maxNumber - minNumber;
    return subtraction;
}
Console.Write("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(" | ", array)}]");
Console.WriteLine($"Разница между макс и мин элементами массива = {Result(array)}");