// программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
// не могу только понять почему не проверяет числа с "0" на концах

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