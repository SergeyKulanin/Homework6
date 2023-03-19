// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double ConvertStringToNumbers(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}
double b1 = ConvertStringToNumbers("Введите переменную b1: ");
double k1 = ConvertStringToNumbers("Введите переменную k1: ");
double b2 = ConvertStringToNumbers("Введите переменную b2: ");
double k2 = ConvertStringToNumbers("Введите переменную k2: ");

double FindXPosition()
{
    double x = -(b1 - b2) / (k1 - k2);
    return x;
}
double FindYPosition()
{
    double X = FindXPosition();
    double y = k1 * X + b1;
    return y;
}

Console.WriteLine($"Прямые пересекаются в точке: ({FindXPosition()};{FindYPosition()})");