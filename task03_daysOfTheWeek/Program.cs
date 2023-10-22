/*
 Программа, которая по номеру выдаёт день недели.
 1--> Понедельник;
 2--> Вторник;
 ...
*/
Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("Понедельник");
}
else if(number == 2)
{
    Console.WriteLine("Вторник");
}
else if(number == 3)
{
    Console.WriteLine("Среда");
}
else if(number == 4)
{
    Console.WriteLine("Четверг");
}
else if(number == 5)
{
    Console.WriteLine("Пятница");
}
else if(number == 6)
{
    Console.WriteLine("Сууббота");
}
else if(number == 7)
{
    Console.WriteLine("Воскресенье");
}
else System.Console.WriteLine("Неправильный номер");




