// программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Clear ();
Console.WriteLine("Введите первое число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = int.Parse(Console.ReadLine());

if (n > m)
Console.WriteLine($"max {n}  min {m}");

else if (n < m)
Console.WriteLine($"max {m}  min {n}");

else
Console.WriteLine("Числа ровны");