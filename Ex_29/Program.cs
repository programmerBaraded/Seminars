// программa, которая спрашивает у пользователя кол-во элементов и спршивает сами элементы. 
// После записи элементов в массив, необходимо его вывести на экран.

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.Write("Введите нижний предел массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний предел массива: ");
int max = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
array[i] = new Random().Next(min, max);

Console.WriteLine($"[{string.Join(", ", array)}]");