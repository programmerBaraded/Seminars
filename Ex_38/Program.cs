// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(-100, 101); // [-100, 100]
}


void Dif(int[] array)
{
int dif = 0;
    dif = array.Max() - array.Min();
Console.WriteLine($"Разница {dif}");
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Dif(array);