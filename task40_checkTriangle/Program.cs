// Task 40. Проверьте есть ли треугольник с введёнными пользователем сторонами.
void CheckTriangle(double firstSide,
double secondSide, double thirdSide)
{
    if(firstSide+secondSide>thirdSide&&
       secondSide+thirdSide>firstSide&&
       firstSide+thirdSide>secondSide
    )
    {
        Console.WriteLine("Треугольник существует!!!");
    }
    else Console.WriteLine("Треугольник не существует!");
}

Console.Write("Введите первую сторону треугольника: ");
double firstUserSide = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите вторую сторону треугольника: ");
double secondUserSide = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третью сторону треугольника: ");
double thirdUserSide = Convert.ToDouble(Console.ReadLine());
// Вызов функции.
CheckTriangle(firstUserSide,secondUserSide,thirdUserSide);