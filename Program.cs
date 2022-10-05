
// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь
// 

void Zadacha41()
{
    Console.WriteLine("____________________");
    Console.WriteLine("Задача 41");
    Random random = new Random();
    int M = random.Next(2, 5);
    Console.WriteLine($"Необходимо ввести {M} чисел, как положительных, так и отрицательных: ");
    int positive_number = 0;
    for (int i = 1; i <= M; i++)
    {
        Console.WriteLine($"Введите {i} число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) positive_number++;
    }
    Console.WriteLine($"Количество введенных положительных чисел = {positive_number}");

}

Zadacha41();

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//  
//

void Zadacha43()
{
    Console.WriteLine("____________________");
    Console.WriteLine("Задача 43");
    Console.WriteLine($"Необходимо ввести 4 числа, которые будут являться параметрами уравнений для двух прямых: ");
    Console.WriteLine($"Введите 1-ый параметр b1 для уравнения 1-ой прямой: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите 2-ой параметр k1 для уравнения 1-ой прямой: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите 1-ый параметр b2 для уравнения 2-ой прямой: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите 2-ой параметр k2 для уравнения 2-ой прямой: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых А({x}, {y}).");

}
Zadacha43();