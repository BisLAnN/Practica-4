using System;
using ConvexQuadLib;

namespace параллелограмм
{
    class Program
    {
        static void Main(string[] args)
        {
            /*вычисление углов в градусах
             *вычисление длин диагоналей
             *вычисление длин сторон
             *вычисление периметра
             *вычисление площади
             */
            double a, b, c, d, d1, d2;

            Console.WriteLine("\n\nПараллелограмм:");
            Parallelogram parallelogram = new Parallelogram(-3, 1, -4, 4, 0, 4, 1, 1);
            parallelogram.DisplayPoints();
            parallelogram.GetAngles(out a, out b, out c, out d);
            Console.WriteLine($"Углы:\nA = {a}\nB = {b}\nC = {c}\nD = {d}");
            parallelogram.GetDiagonalsLength(out d1, out d2);
            Console.WriteLine($"\nДиагонали:\nd1 = {d1}\nd2 = {d2}");
            parallelogram.GetSides(out a, out b, out c, out d);
            Console.WriteLine($"\nСтороны:\na = {a}\nb = {b}\nc = {c}\nd = {d}");
            Console.WriteLine($"Периметр = {parallelogram.GetPerimeter()}");
            Console.WriteLine($"Площадь = {parallelogram.GetArea()}");

            Console.WriteLine("\n\nРомб:");
            Rhombus rhombus = new Rhombus(-1, -2, 0, 0, 1, -2, 0, -3);
            rhombus.DisplayPoints();
            rhombus.GetAngles(out a, out b, out c, out d);
            Console.WriteLine($"Углы:\nA = {a}\nB = {b}\nC = {c}\nD = {d}");
            rhombus.GetDiagonalsLength(out d1, out d2);
            Console.WriteLine($"\nДиагонали:\nd1 = {d1}\nd2 = {d2}");
            rhombus.GetSides(out a, out b, out c, out d);
            Console.WriteLine($"\nСтороны:\na = {a}\nb = {b}\nc = {c}\nd = {d}");
            Console.WriteLine($"Периметр = {rhombus.GetPerimeter()}");
            Console.WriteLine($"Площадь = {rhombus.GetArea()}");

            Console.WriteLine("\n\nКвадрат:");
            Square sqaure = new Square(1, 1, 1, 3, 3, 3, 3, 1);
            sqaure.DisplayPoints();
            sqaure.GetAngles(out a, out b, out c, out d);
            Console.WriteLine($"Углы:\nA = {a}\nB = {b}\nC = {c}\nD = {d}");
            sqaure.GetDiagonalsLength(out d1, out d2);
            Console.WriteLine($"\nДиагонали:\nd1 = {d1}\nd2 = {d2}");
            sqaure.GetSides(out a, out b, out c, out d);
            Console.WriteLine($"\nСтороны:\na = {a}\nb = {b}\nc = {c}\nd = {d}");
            Console.WriteLine($"Периметр = {sqaure.GetPerimeter()}");
            Console.WriteLine($"Площадь = {sqaure.GetArea()}"); ;
            Console.ReadKey();
        }
    }
}
