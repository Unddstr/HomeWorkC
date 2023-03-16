// Задача со звездочкой
using System.IO;
Console.Clear();

StreamReader sr = new StreamReader("C:\\Users\\user\\Desktop\\INPUT.txt");
string line;
line = sr.ReadLine();

int[] a;
a = Array.ConvertAll(line.Split(), int.Parse);

sr.Close();
int maxFirstNumber = a[0];
int maxSecondNumber = a[0];
int maxIndex = 0;
for (int i = 0; i < a.Length; i++)
{

    if (a[i] > maxFirstNumber)
    {
        maxFirstNumber = a[i]; 
        maxIndex = i;
    }

        if (a[i] == 0)
        break;
}
a[maxIndex] = -1;

for (int i = 0; i < a.Length; i++)
{

    if (a[i] > maxSecondNumber)
    {
        maxSecondNumber = a[i]; 
    }

        if (a[i] == 0)
        break;
}
StreamWriter sw = new StreamWriter("C:\\Users\\user\\Desktop\\OUTPUT.txt");

sw.WriteLine(maxSecondNumber);

sw.Close();
