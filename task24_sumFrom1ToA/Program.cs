/*
    Напишите программу, которая выдаёт сумму чисел от 1 до A 
    (A вводится пользователем).
*/ 
Console.Clear();
int sumOfNumbers(int num)
{
    int sum = 0;
    if(num < 1) return -1;
    for(int i = 1;i <= num;i++)
    {
        sum = sum + i;
    }
    return sum;
}
Console.Write("Введите ваше число: ");
int A = Convert.ToInt32(Console.ReadLine());
int userSum = sumOfNumbers(A);
Console.WriteLine($"Сумма чисел от 1 до {A} равняется {userSum}");
