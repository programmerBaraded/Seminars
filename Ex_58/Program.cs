
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 4);
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

int[,] ReleaseMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatrix.GetLength(1); j++)
            result[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
    }
    return result;
}


Console.Clear();
Console.Write("Введите размеры матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] firstMatrix = new int[size[0], size[1]];
int[,] secondMatrix = new int[size[0], size[1]];
InputMatrix(firstMatrix);
InputMatrix(secondMatrix);
Console.WriteLine("Первая матрица");
PrintMatrix(firstMatrix);
Console.WriteLine("\nВторая матрица");
PrintMatrix(secondMatrix);

ReleaseMatrix(firstMatrix, secondMatrix);
Console.WriteLine("\nПроизведение двух матриц");
PrintMatrix(ReleaseMatrix(firstMatrix, secondMatrix));