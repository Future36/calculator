using System;
using System.Numerics;
namespace Calculator
{
class Program
{
    static int fact(int n)
        {
            int result;

            result = 1;
            for (int i = 1; i<=n; i++)
            {
                result *=i;
            }

            return result;
        }
    static void Main(string[] args)
    {
        int q = 1;
        int o;
        int a = 0;
        double n = 0;
        double firstValue, secondValue;
        string action;

        while (q < 9)
        {
        
        Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ 1: Если у вас операция со степенью, то второе вводимое число - это степень");
        Console.WriteLine("ПРЕДУПРЕЖДЕНИЕ 2: Если у вас операция с корнем, то второе число не используется");
        Console.WriteLine("Введите число 1: ");
        firstValue = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите число 2: ");
        secondValue = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Введите число 3 (для факториала. Если не нужно, не используйте): ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("Выберите операцию: +, -, *, /, %, ^, sqrt, ~. \nДругие названия операций: сложение, вычитание, умножение, деление, процент, степень, корень, факториал");
        action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "cложение":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "вычитание":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "умножение":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("Делить на 0 нельзя");
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    case "деление":
                        if (secondValue == 0)
                            Console.WriteLine("Делить на 0 нельзя");
                        else
                            Console.WriteLine(firstValue / secondValue);
                        break;
                    case "%":
                            Console.WriteLine((firstValue / secondValue) * 100 + "%");
                        break;
                    case "процент":
                        Console.WriteLine((firstValue / secondValue) * 100 + "%");
                        break;
                    case "^":
                        n = firstValue;
                        for (int i=1; i<secondValue; i++)
                        {
                            firstValue = firstValue * n;
                        }
                        Console.WriteLine(firstValue);
                        break;
                    case "степень":
                        n = firstValue;
                        for (int i = 1; i < secondValue; i++)
                        {
                            firstValue = firstValue * n;
                        }
                        Console.WriteLine(firstValue);
                        break;
                    case "sqrt":
                        Console.WriteLine(Math.Sqrt(firstValue));
                        break;
                    case "корень":
                        Console.WriteLine(Math.Sqrt(firstValue));
                        break;
                    case "~":
                        Console.WriteLine("{0}!={1}", a, fact(a));
                        break;
                    case "факториал":
                        Console.WriteLine("{0}!={1}", a, fact(a));
                        break;
                    default:
                        Console.WriteLine("Неверное выбранное значение");
                        break;
                }
                Console.WriteLine("Если хотите выйти, нажмите 9");
                q = int.Parse(Console.ReadLine());

                if (q == 9)
                {

                }
                Console.WriteLine("Если хотите очистить окно нажмите 1, если нет - любое число");
                a = int.Parse(Console.ReadLine());

                if (a == 1)
                {
                    Console.Clear();
                }

                
            }
    }
} }
