/*
   По введенной цифре, обозначающей день недели, определить является ли день выходным.   
*/ 
Console.Clear();
Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day < 1 || day > 7)
{
    Console.Write("Такого дня недели нет!");
}
else if(day < 6)
{
    Console.Write("Это рабочий день");
}
else Console.Write("Это выходной!!!");

