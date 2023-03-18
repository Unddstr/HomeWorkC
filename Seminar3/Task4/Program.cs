// Задача со звездочкой
Console.Clear();
int[] arr = { 5, 4, 3, 11, 7, 6};
int max = 0;

for (int i = 0; i < arr.Length - 2; i++)
{
    max = arr[i] + arr[i + 1] + arr[i + 2];
}
int a = arr[^2] + arr[^1] + arr[0];
int b = arr[^1] + arr[0] + arr[1];

if (a > max && a > b)
    max = a;
if (b > max && b > a)
    max = b;

Console.WriteLine($"{max}");