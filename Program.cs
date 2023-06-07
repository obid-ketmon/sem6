// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

/*Console.Write("Введите числа через запятую: ");
        string input = Console.ReadLine();
        
        string[] numbers = input.Split(',');
        int count = 0;
        
        foreach (string number in numbers)
        {
            int parsedNumber;
            if (int.TryParse(number.Trim(), out parsedNumber))
            {
                if (parsedNumber > 0)
                {
                    count++;
                }
            }
        }
        
Console.WriteLine("Количество чисел больше 0: " + count);*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

   /*     Console.WriteLine("Введите коэффициенты для первой прямой:");
        Console.Write("k1: ");
        double k1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("b1: ");
        double b1 =  Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите коэффициенты для второй прямой:");
        Console.Write("k2: ");
        double k2 =  Convert.ToInt32(Console.ReadLine());
        Console.Write("b2: ");
        double b2 =  Convert.ToInt32(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("Точка пересечения прямых: ({0}, {1})", x, y);*/
