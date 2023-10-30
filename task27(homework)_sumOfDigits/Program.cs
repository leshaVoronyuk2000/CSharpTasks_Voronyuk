/*
    Task 27
    Сумма цифр в числе
*/ 

int sumOfDigits(int num)
{
    int sum = 0;
    for(int i = num;i > 0;i = i/10)
    {   
        sum = sum + i%10;
    }
    return sum;
}

Console.Write("Введите ваше число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumOfDigits(A));
