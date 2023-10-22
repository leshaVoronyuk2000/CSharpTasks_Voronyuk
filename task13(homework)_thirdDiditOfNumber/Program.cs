/*
    Показать третью цифру числа. Если её нет сообщить об этом.
    78 --> Третьей цифры нет.
    666 --> 6
    66767 --> 7
*/ 
Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100)  //&&(number > -100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    int temp = number;
    while(temp > 999)
    {
        temp = temp / 10;
    }
    int thirdDigit = temp % 10;
    Console.Write("Третья цифра: " + thirdDigit);
}