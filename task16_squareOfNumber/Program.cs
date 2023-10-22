/*
   Task 16
   Проверить, является ли одно число квадратом другого;
    8, 64 --> да
    57, 6 --> нет
    256, -16 --> да
*/ 
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1 == number2*number2)
{
    System.Console.WriteLine("Да");
}
else if(number2 == number1*number1)
{
    System.Console.WriteLine("Да");
}
else System.Console.WriteLine("Нет");