using System;

namespace LabWorkSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца:");
            int monthNumber;
            for (; ; )
            {
                for (; ; )
                {
                    if (int.TryParse(Console.ReadLine(), out monthNumber))
                    {
                        if (monthNumber >= 1 && monthNumber <= 12)
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
                if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
                {
                    Console.WriteLine(monthNumber + " месяц года это зима.");
                }
                else if (monthNumber == 3 || monthNumber == 4 || monthNumber == 5)
                {
                    Console.WriteLine(monthNumber + " месяц года это весна.");
                }
                else if (monthNumber == 6 || monthNumber == 7 || monthNumber == 8)
                {
                    Console.WriteLine(monthNumber + " месяц года это лето.");
                }
                else
                {
                    Console.WriteLine(monthNumber + " месяц года это осень.");
                }
            }
        }
    }
}
