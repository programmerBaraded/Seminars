// программa, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// !!! Нельзя использовать функцию Math.Pow

Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int resalt = A;
for (int i = 1; i < B; i++)
{
    resalt = resalt * A;
}
Console.Write(resalt);