/*
    Напишите программу, которая выводит все чётные числа от 1 до number.
*/ 
Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int start = 1;

while(start <= number)
{
    if(start % 2 == 0)
    {
        Console.Write(start+"\t");
    }
    start++;
}
