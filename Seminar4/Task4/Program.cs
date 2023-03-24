// Задача со звездочкой: Сдвинуть массив на k позиций
Console.Clear();
int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };
int k = 0;
int[] array2 = new int[array.Length];

k = k % array.Length;

if (k > 0)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i + k >= array.Length)
        {
            array2[i + k - array.Length] = array[i];
        }
        else
        {
            array2[i + k] = array[i];
        }
    }
}
else
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i + k < 0)
        {
            array2[array.Length + k + i] = array[i];
        }
        else
        {
            array2[i + k] = array[i];
        }
    }
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine(" ");

for (int i = 0; i < array2.Length; i++)
{
    Console.Write(array2[i] + " ");
}
