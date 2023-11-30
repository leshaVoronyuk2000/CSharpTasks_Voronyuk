// Task 69. Программа, которая первое число возводит в степень второго
Console.WriteLine("Hello, World!");

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}


int MyPow(int n1,int n2)
{
    if(n2 == 1) return n1;
    else return n1 * MyPow(n1,n2-1);
}

int userNum = Prompt("Введите ваше число: ");
int exponent = Prompt("Введите показатель степени: ");
int result = MyPow(userNum,exponent);
System.Console.WriteLine($"{userNum} в степени {exponent} равняется {result}");