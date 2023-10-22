/*
  Определтите большее и меньшее число из двух
*/
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber)
{
    Console.WriteLine("Первое число больше, а второе меньше");
}
else if(firstNumber < secondNumber)
{
   Console.WriteLine("Второе число больше, а первое меньше"); 
}
else Console.WriteLine("Числа равны");