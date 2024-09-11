using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Laba__2
{
    internal class Program
    {
        public static void F1()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int ans = x % 2;
            if (ans == 0) Console.WriteLine(2);
            else Console.WriteLine(1);
        }
        public static void F2()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            if (a + b > c && a + c > b && c + b > a)
            {
                double ct = Math.Max(c, Math.Max(a, b));
                double bt = Math.Min(c, Math.Min(a, b));
                double at = a + b + c - ct - bt;
                if (ct * ct == bt * bt + at * at) Console.WriteLine("Данный треугольник является прямоугольным");
                else Console.WriteLine(Math.Acos((a * a + b * b - c * c) / (2 * a * b)));

            }
            else Console.WriteLine("Треугольник не существует");
        }
        public static int F3()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (x >= 50)
            {
                Console.WriteLine("Стоять нет смысла");
                return 0;
            }
            if (x % 2 != 0) x -= 1;
            Console.WriteLine($"Стоять {x * 10} минут");
            return 0;
        }
        public static void F4()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            double s = Convert.ToDouble(Console.ReadLine());
            switch (x)
            {
                case 1:
                    Console.WriteLine(s * 0.07);
                    break;
                case 2:
                    Console.WriteLine(s * Math.Pow(1.08, 3) - s);
                    break;
                case 3:
                    Console.WriteLine(s * Math.Pow(1.1, 5) - s);
                    break;
            }
        }
        public static void F5()
        {
            int x = Convert.ToInt32(Console.ReadLine());
            if (0 < x && x <= 110) Console.WriteLine("штрафа нет");
            else if (110 < x && x <= 130) Console.WriteLine("штраф 500 рублей");
            else if (130 < x && x <= 150) Console.WriteLine("штраф 1500 рублей");
            else if (150 < x && x <= 170) Console.WriteLine("штраф 2500 рублей или лишение прав");
            else Console.WriteLine("штраф 5000 рублей или лишение прав на 4 года");
        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Выберите номер задания");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    F1(); break;
                case 2:
                    F2(); break;
                case 3:
                    F3(); break;
                case 4:
                    F4(); break;
                case 5:
                    F5(); break;
            }
        }
    }
}
