// программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Clear();

int[] nums = { 2, 3, 7 };
 
int max = int.MinValue;
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
        // найден больший элемент
        max = nums[i];
    }
}
    Console.WriteLine($"Вывод максимального числа {max}");