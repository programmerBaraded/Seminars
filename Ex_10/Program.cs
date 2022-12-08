// программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int n1 = n % 100;
int n2 = n1 / 10;
Console.WriteLine(n2);