// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
int[,] TransformationArrayWhole (double[,] matrix)
{
  int[,] matrixWhole = new int[matrix.GetLength(0), matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrixWhole[i, j] = Convert.ToInt32(matrix[i, j]);
    }
  }
  return matrixWhole;
}

Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrixWhole = new int[size[0], size[1]];
InputMatrix(matrixWhole);


Console.Write($"\nCреднее арифметическое:\n");
for (int i = 0; i < size[0]; i++)
{
  double arithmeticMean = 0;
  for (int j = 0; j < size[1]; j++)
  {
    arithmeticMean += matrixWhole[j, i];
  }
  arithmeticMean = Math.Round(arithmeticMean / size[1], 1);
  Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
}
