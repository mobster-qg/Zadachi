// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Clear();
Console.WriteLine( "Введите число:" );

int N = int.Parse(Console.ReadLine());
int b = N;
while( b % 2 == N)
{
    Console.Write($"{b}");
    b++;
}