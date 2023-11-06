// Task 24 Преобразуйти число в двоичный вид.

string BinaryNum(int number)
{
    string binNum = string.Empty;
    for(int i = number;i > 0;i = i/2)
    {
        binNum = i%2 + binNum;
    }
    return binNum;
}

Console.WriteLine(2 +" --> "+BinaryNum(2));
