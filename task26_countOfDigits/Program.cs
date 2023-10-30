/*
    Task 26
    Напишите программу, которая показывает количество цифр в числе.
*/ 

int countOfDigits(int num)
{
    int sum = 0;
    for(int i = num;i > 0;i = i/10)
    {
        sum = sum + 1;
    }
    return sum;
}

Console.Write("Введите ваше число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
int count = countOfDigits(userNum);
Console.WriteLine($"Количество цифр в {userNum} равняется {count}");
