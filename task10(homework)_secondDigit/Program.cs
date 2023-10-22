/*
    Выведите вторую цифру трехзначного числа
    456 --> 5
    666 --> 6
*/
Console.Clear();
Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100 || number > 999)
{
    Console.WriteLine("Число не трёхзначное");
}
else{
    int secondDigit = number / 10 % 10;
    Console.WriteLine("Вторая цифра " + secondDigit);
}

