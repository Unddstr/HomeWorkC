// Программа, которая на вход принимает  позиции элемента в двумерном массиве
// и возвращает значение этого элемента или указание, что такого элемента
// не существует
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(0, 10);
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void PrintElement(int[,] matrix, int[] element)
{
    if (element[0] < matrix.GetLength(0) && element[0] >= 0 
    && element[1] < matrix.GetLength(1) && element[1] >= 0)
        Console.WriteLine(matrix[element[0], element[1]]);
    else
        Console.WriteLine($"{element[0]}, {element[1]} - такой позиции нет");
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите позицию элемента массива: ");
int[] element = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
PrintElement(matrix, element);