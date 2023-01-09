// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int sum (int m, int n)
{
    if (m > n)
        return 0;
    return sum(m + 1, n) + m;
}

Console.Clear ();
Console.WriteLine ("Введите первое число: ");
int m = int.Parse (Console.ReadLine ());
Console.WriteLine ("Введите второе число: ");
int n = int.Parse (Console.ReadLine ());
Console.WriteLine (sum (m, n));