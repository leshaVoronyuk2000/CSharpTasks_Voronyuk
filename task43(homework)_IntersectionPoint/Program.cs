// Task 43 Определите точку пересечения двух функций.
void ShowIntersectionPoint(int k1,int b1,
                            int k2,int b2)
{
    
    if(k1==k2&&b1==b2)
    {
        System.Console.WriteLine("Графики полностью совпадают");
    }
    else if(k1==k2)
    {
        System.Console.WriteLine("Графики не совпадают");
    }
    else
    {
        int x = (b2 - b1)/(k1-k2);
        int y = k1*x + b1;
        System.Console.WriteLine($"Координаты пересечения графиков ({x},{y})");
    }
}

System.Console.Write("Введите k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
ShowIntersectionPoint(k1,b1,k2,b2);

