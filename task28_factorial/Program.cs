// See https://aka.ms/new-console-template for more information
Console.Clear();
long factorial(int num)
{
    if(num < 0) return -1;
    long result = 1;
    for(int i = 1;i <= num;i++)
    {
        result = result * i;
    }
    return result;
}
Console.Write("Введите ваше число: ");
int userNum = Convert.ToInt32(Console.ReadLine());
long userFactorial = factorial(userNum);
Console.WriteLine($"Произведение чисел от 1 до {userNum} равняется {userFactorial}");

