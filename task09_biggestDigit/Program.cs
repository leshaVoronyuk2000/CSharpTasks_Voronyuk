/*
  Напишите программу, которая выводит случайное число из отрезка [10,99]
  и показзывает наибольшую цифру числа.
*/

int number = new Random().Next(10,100);
int firstDigit = number / 10;
int secondDigit = number % 10;
System.Console.WriteLine(number);
if(firstDigit > secondDigit)
{
    Console.WriteLine("Наибольшая цифра " + firstDigit);
}
else if(firstDigit < secondDigit)
{
    Console.WriteLine("Наибольшая цифра " + secondDigit);
}
else Console.WriteLine("Цифры равны");