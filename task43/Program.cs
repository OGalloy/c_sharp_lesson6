/*Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)*/
Console.WriteLine("Программа нахождения точки пересечения двух прямых.");
Console.WriteLine("Прямые имеют вид: y = k1 * x + b1, y = k2 * x + b2 ");
Console.WriteLine("Введите коэффициент k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите коэффициент b2");
double b2 = Convert.ToDouble(Console.ReadLine());
//Проверки совпадения и параллельности прямых.
if (k1 - k2 == 0)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают и имеют бесконечное число решений");
    }
    else
    {
        Console.WriteLine("Прямые параллельны.");
    }   
}
else
{
    double[] point = calculateCrossPoint(k1, b1, k2, b2);
    Console.WriteLine("Координаты пересечения прямых: ({0}, {1})", point[0], point[1]);
}

//Функция расчёта точки пересечения.
double[] calculateCrossPoint(double k1, double b1, double k2, double b2)
{
    double[] point = new double[2];
    point[0] = (b2 - b1) / (k1 - k2);
    point[1] = k2 * point[0] + b2;
    return point; 
}

