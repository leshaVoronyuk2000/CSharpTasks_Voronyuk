/*
  Удалить вторую цифру из трёхзначного случайного числа
  666 --> 66
  515 --> 55
*/ 
int number = new Random().Next(100,1000);
Console.WriteLine(number);
int newNumber = ((number / 100) * 10) + (number % 10);
Console.WriteLine(newNumber);
