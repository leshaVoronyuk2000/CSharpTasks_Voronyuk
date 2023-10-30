/*
    Task 25
    Напишите программу, которая возводит число A в натуральную степень B.
*/ 
Console.Clear();
double power(double num, int exp)
{
    double result = num;
    for(int i = 1;i < exp;i++)
    {
        result = result * num;
    }
    return result;
}

bool validateExponent(int exp)
{
    if(exp > 0)
    {
        return true;
    } 
    else return false;
}

Console.Write("Введите основание степени: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите показатель степени число: ");
int B = Convert.ToInt32(Console.ReadLine());

if(validateExponent(B))
{
    Console.Write(power(A,B));
}
else Console.Write(-1);

