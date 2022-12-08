// программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()); //код работает до момента привышения критического размера памяти
if (n < 0)
{
    int k = n * -1;
    n = k;
}
while (n > 1000)
{
 int n1 = n / 10;
 n = n1;
}
if (n > 99)
{
    int n1 = n % 10;
    Console.WriteLine(n1);
    //Console.WriteLine((n % 100) % 10); //
}
else
{
    Console.WriteLine("третьей цифры нет");
}