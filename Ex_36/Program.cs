// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(1, 100); // [1, 999]

}

void SumNech(int[] array)
{
int sumNech = 0;
for (int i = 0; i < array.Length; i++)
{
if (i % 2 == 1)
sumNech +=array[i];
}
Console.WriteLine($"Сумма нечетныхных чисел равна {sumNech}");
}

Console.Clear();
Console.WriteLine("Введите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
SumNech(array);