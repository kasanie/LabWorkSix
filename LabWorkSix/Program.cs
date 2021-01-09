using System;

namespace LabWorkSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца:");
            int month;
            for (; ; )
            {
                for (; ; )
                {
                    if (int.TryParse(Console.ReadLine(), out month))
                    {
                        if (month >= 1 && month <= 12)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка. Введите номер месяца:");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка. Введите номер месяца:");
                        continue;
                    }

                }
                Season(month);
                
            }
        }
        static void Season(int x)
        {
            switch (x)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine(x + " месяц года это зима.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine(x + " месяц года это весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine(x + " месяц года это лето");
                    break;
                default:
                    Console.WriteLine(x + " месяц года это осень");
                    break;

            }
        }
    }
}
