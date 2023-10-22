/*
    Выведите последнюю цифру трёхзначного числа
*/
Console.Write("Введите любое число от -999 до -100 либо от 100 до 999: ");
int number = Convert.ToInt32(Console.ReadLine());
if((number < 100 && (number < -999 || number > -100)) || number > 999)
{
    Console.WriteLine("Неправильное число");
}
else
{
    int lastDigit = number % 10;
    if(lastDigit < 0) lastDigit = lastDigit*(-1);
    Console.WriteLine("Последняя цифра " + lastDigit);
}
