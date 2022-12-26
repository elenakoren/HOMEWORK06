/* Напишите программу, которая найдёт точку пересечения двух прямых, 
+ заданных уравнениями у = k1 * x + b1, y = k2 * x + b2; 
+ значения b1, k1, b2 и к2 задаются пользователем.*/

double GetNumber(string message)
{
    double result;
    while (true)
    {
        Console.WriteLine(message);
        if (double.TryParse(Console.ReadLine(),out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}
double b1 = GetNumber("Введите число B1:");
double k1 = GetNumber("Введите число K1:");
double b2 = GetNumber("Введите число B2:");
double k2 = GetNumber("Введите число K2:");
double x = (b2-b1)/(k1-k2);
double y = k2 * x + b2;

Console.WriteLine($"координаты пересечения X:{x},Y{y}");

