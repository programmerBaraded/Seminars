// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

/// !!!! Списал у Дениса

void Input3DMatrix(int[, ,] matrix)
{
    int n = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int p = 0; p < matrix.GetLength(2); p++)
            {
                matrix[i, j, p] = n++;
            }
        }
    }
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int p = 0; p < matrix.GetLength(2); p++)
            {
                Console.WriteLine($"{matrix[i, j, p]} ({i}, {j}, {p})");
            }
        }
    }
}
Console.Clear();
Console.Write("Введите размер трехмерной матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (size[0] * size[1] * size[2] > 99)
{
    Console.WriteLine("Размер матрицы не допустим. \nВведите размер трехмерной матрицы: ");
    size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int[,,] matrix3D = new int[size[0], size[1], size[2]];
Input3DMatrix(matrix3D);
PrintMatrix(matrix3D);