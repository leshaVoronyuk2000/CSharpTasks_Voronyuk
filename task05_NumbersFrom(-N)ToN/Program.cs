/*
   Напишите программу, которая на вход принимает одно число N, 
   а на выходе показывает промежуток чисел от -N до N.
*/
Console.Write("Введите любое число от 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int start = -1*N;

while(start <= N)
{
    Console.WriteLine(start++);
}