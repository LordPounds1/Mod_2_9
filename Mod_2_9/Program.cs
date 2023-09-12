using System;

namespace Mod_2_3
{
    class Program
    {
        static string num_Of_year(int b)
        {
            if (b == 1)
            {
                return "Январь";
            }
            else if (b == 2)
            {
                return "Февраль";
            }
            else if (b == 3)
            {
                return "Март";
            }
            else if (b == 4)
            {
                return "Апрель";
            }
            else if (b == 5)
            {
                return "Май";
            }
            else if (b == 6)
            {
                return "Июнь";
            }
            else if (b == 7)
            {
                return "Июль";
            }
            else if (b == 8)
            {
                return "Август";
            }
            else if (b == 9)
            {
                return "Сентябрь";
            }
            else if (b == 10)
            {
                return "Октябрь";
            }
            else if (b == 11)
            {
                return "Ноябрь";
            }
            else if (b == 12)
            {
                return "Декабрь";
            }
            else
            {
                return "Введите число от 1 до 12";
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер месяца: ");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = num_Of_year(a);
            Console.WriteLine(b);
        }
    }
}