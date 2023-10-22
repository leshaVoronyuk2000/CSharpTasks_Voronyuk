/*
    Проверить, кратно ли первое число второму. Если нет вывести остаток.
*/ 
Console.Clear();
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber % secondNumber == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    int remainder = firstNumber % secondNumber;
    Console.WriteLine("Некратно, остаток " + remainder);
}


