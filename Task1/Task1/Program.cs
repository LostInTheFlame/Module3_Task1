using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            string A = Console.ReadLine();
            if (int.TryParse(A, out int a))
            {
                Console.Write("Введите второе число: ");
                string B = Console.ReadLine();
                if (int.TryParse(B, out int b))
                {
                    int result = 0;
                    if (b < 0)
                    {
                        for (int i = 1; i <= -b; i++)
                        {
                            result = result + -a;
                        }
                        Console.WriteLine($"a * b = {result}");
                    }
                    else
                    {
                        for (int i = 1; i <= b; i++)
                        {
                            result = result + a;
                        }
                        Console.WriteLine($"a * b = {result}");
                    }
                }
                else Console.WriteLine("Значение введено неверно.");
            }
            else Console.WriteLine("Значение введено неверно.");
            Console.ReadKey();
        }
    }
}