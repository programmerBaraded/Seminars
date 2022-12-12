// программa, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
string s = n.ToString();
int x = 0;
for (int i = 0; i < s.Length / 2; i++)
{
    if (s[i] == s[s.Length - 1 - i])
    {
       x++; 
    }
    
}
if (x == s.Length / 2)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}