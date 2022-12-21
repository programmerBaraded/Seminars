// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.


int[] s = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int p = 0;
foreach (int element in s)
    if (element > 0)
        p++;
Console.WriteLine(p);