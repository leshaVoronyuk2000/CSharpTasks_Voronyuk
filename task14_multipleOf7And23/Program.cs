/*
    Проверить является ли число кратным 7 и 23
*/

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if((number % 7 == 0) &&  (number % 23 == 0))
{
    Console.WriteLine("Число кратно и 23 и 7");
}
else
{
    Console.WriteLine("Число не кратно и 23 и 7");
}