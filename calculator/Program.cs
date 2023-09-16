using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while (choice != 9)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложить два числа");
            Console.WriteLine("2. Вычесть первое число из второго");
            Console.WriteLine("3. Умножить два числа");
            Console.WriteLine("4. Разделить первое число на второе");
            Console.WriteLine("5. Возвести первое число в степень");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1% от числа");
            Console.WriteLine("8. Найти факториал числа");
            Console.WriteLine("9. Выйти из программы");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    double sum = num1 + num2;
                    Console.WriteLine($"Сумма: {sum}");
                    break;
                case 2:
                    Console.Write("Введите первое число: ");
                    double minuend = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double subtrahend = Convert.ToDouble(Console.ReadLine());
                    double difference = minuend - subtrahend;
                    Console.WriteLine($"Разность: {difference}");
                    break;
                case 3:
                    Console.Write("Введите первое число: ");
                    double factor1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double factor2 = Convert.ToDouble(Console.ReadLine());
                    double product = factor1 * factor2;
                    Console.WriteLine($"Произведение: {product}");
                    break;
                case 4:
                    Console.Write("Введите первое число: ");
                    double dividend = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double divisor = Convert.ToDouble(Console.ReadLine());

                    if (divisor != 0)
                    {
                        double quotient = dividend / divisor;
                        Console.WriteLine($"Частное: {quotient}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    break;
                case 5:
                    Console.Write("Введите число: ");
                    double baseNumber = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    double exponent = Convert.ToDouble(Console.ReadLine());
                    double power = Math.Pow(baseNumber, exponent);
                    Console.WriteLine($"Результат возведения в степень: {power}");
                    break;
                case 6:
                    Console.Write("Введите число: ");
                    double number = Convert.ToDouble(Console.ReadLine());

                    if (number >= 0)
                    {
                        double squareRoot = Math.Sqrt(number);
                        Console.WriteLine($"Квадратный корень: {squareRoot}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: отрицательное число под корнем!");
                    }
                    break;
                case 7:
                    Console.Write("Введите число: ");
                    double originalNumber = Convert.ToDouble(Console.ReadLine());
                    double percent = 0.01 * originalNumber;
                    Console.WriteLine($"1% от числа: {percent}");
                    break;
                case 8:
                    Console.Write("Введите число: ");
                    int factorialNumber = Convert.ToInt32(Console.ReadLine());

                    if (factorialNumber >= 0)
                    {
                        int result = 1;

                        for (int i = 1; i <= factorialNumber; i++)
                        {
                            result *= i;
                        }

                        Console.WriteLine($"Факториал числа: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: факториал отрицательного числа не определен!");
                    }
                    break;
                case 9:
                    Console.WriteLine("Программа завершена.");
                    break;
                default:
                    Console.WriteLine("Неверная операция! Попробуйте еще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }
}