// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.WriteLine("Введите числа: ");

double numberA = FillNumber();
double numberB = FillNumber();
Console.WriteLine($"{pow (numberA, numberB)}");

double FillNumber()
{
    return double.Parse(Console.ReadLine());
}

double pow(double numberA, double numberB)
{  
    return (Math.Pow(numberA, numberB));    
}

