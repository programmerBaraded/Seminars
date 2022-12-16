using System.ComponentModel;
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(100, 1000); // [100, 999]
}


void ReleasePositive(int[] array)
{
int colPositive = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
colPositive ++;
}
Console.WriteLine($"Количество четных чисел {colPositive}");
}


Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
ReleasePositive(array);