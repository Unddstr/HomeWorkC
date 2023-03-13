// Написать программу которая на вход принимает 3-х значное число,
// а на выходе показывает вторую цифру этого числа
Console.Clear();
int abc = new Random().Next(100, 1000);
Console.WriteLine($"Случаной сгенированное число {abc}");
int a = abc / 100;
int c = abc % 10;
int b = (abc - a * 100 - c)/10;
Console.WriteLine(b);
