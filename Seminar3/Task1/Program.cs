// Написать программу, которая на вход принимает 5 чисел и говорит является ли
// число палиндромом

Console.Clear();
Console.WriteLine("Введите число ");
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n / 10000 == n % 10 && n / 1000 % 10 == n / 10 % 10)
Console.WriteLine("Число является палиндромом");
else
Console.WriteLine("Число не является палиндромом");

//Решениие через строку

// Console.Clear();
// Console.WriteLine("Введите число ");
// string n;
// n = Console.ReadLine()!;

// if (n[0] == n[4]  && n[1] == n[3])
// Console.WriteLine("Число является палиндромом");
// else
// Console.WriteLine("Число не является палиндромом");