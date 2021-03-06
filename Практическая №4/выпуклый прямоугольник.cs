using System;
using System.Collections.Generic;

namespace ConvexQuadLib
{
    public abstract class ConvexQuad
    {
        protected List<Point> points = new List<Point>();
        public ConvexQuad()
        {
            foreach (Point point in points)
            {
                point.X = 0;
                point.Y = 0;
            }
        }
        /// <summary>
        /// Определяет четырехугольник с координатами (x1;y1), (x2;y2), (x3;y3), (x4;y4).
        /// <para>Которые задаются в порядке обхода по часовой стрелке начиная с левого нижнего угла.</para>
        /// </summary>
        public ConvexQuad(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            points.Add(new Point(x1, y1));
            points.Add(new Point(x2, y2));
            points.Add(new Point(x3, y3));
            points.Add(new Point(x4, y4));
        }

        /// <summary>
        /// Просто выводит точки на консоль в удобном виде.
        /// Удобно.
        /// </summary>
        public void DisplayPoints() //просто выводит точки, просто удобно
        {
            foreach (var point in points)
            {
                Console.WriteLine($"x: {point.X}\ty: {point.Y}");
            }
            //Console.WriteLine(points[2].X - points[3].X); //не помню зачем это тут
        }
        //возвращает расстояние между двумя точками с координатами (x1;y1) и (x2;y2). Удобно
        protected double GetDistanceBetweenPoints(Point points1, Point points2)
        {
            return Math.Sqrt(Math.Pow(points2.X - points1.X, 2) + Math.Pow(points2.Y - points1.Y, 2));
        }
        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        abstract public double GetArea();
        /// <summary>
        /// Возврщает углы фигуры. Начиная с левого нижнего угла по часовой стрелке.
        /// </summary>
        abstract public void GetAngles(out double angleA, out double angleB, out double angleC, out double angleD);
        /// <summary>
        /// Возвращает периметр фигуры
        /// </summary>
        abstract public double GetPerimeter();
        /// <summary>
        /// Возвращает стороны фигуры. Где, a - левая сторона, b - верхняя, c - правая, d - нижняя.
        /// </summary>
        abstract public void GetSides(out double a, out double b, out double c, out double d);
        /// <summary>
        /// Возвращает диагонали фигуры. Где, d1 - от левого нижнего до правый верхний углы, d2 - левого верхнего и правого нижнего
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        abstract public void GetDiagonalsLength(out double d1, out double d2);


        //это код для выпуклого четырехугольника, на всякий случай, ну не удалять же мне его :(
        ///// <summary>
        ///// Вычисляет площадь фигуры
        ///// </summary>
        ///// <returns>double area</returns>
        //public virtual double GetArea()
        //{
        //    double d1, d2;
        //    GetDiagonalsLength(out d1, out d2);

        //    double a = GetDistanceBetweenPoints(points[0], points[1]); //находим длину стороны a и других сторон
        //    double b = GetDistanceBetweenPoints(points[1], points[2]);
        //    double c = GetDistanceBetweenPoints(points[2], points[3]);
        //    double d = GetDistanceBetweenPoints(points[3], points[0]);

        //    //находим площадь выпуклого четырехугольника через соотношение Бретшнайдера
        //    return 1d / 4d * Math.Sqrt(4 * Math.Pow(d1, 2) * Math.Pow(d2, 2) - Math.Pow((Math.Pow(b, 2) + Math.Pow(d, 2) - Math.Pow(a, 2) - Math.Pow(c, 2)), 2));
        //}



        ///// <summary>
        ///// Вычисляет и возвращает диагонали заданной фигуры
        ///// </summary>
        ///// <returns>double d1 и double d2 - диагонали</returns>
        //public virtual void GetDiagonalsLength(out double d1, out double d2)
        //{
        //    d1 = GetDistanceBetweenPoints(points[0], points[2]);
        //    d2 = GetDistanceBetweenPoints(points[1], points[3]);
        //}

        ///// <summary>
        ///// Вычисляет и возвращает периметр фигуры
        ///// </summary>
        ///// <returns>double perimeter</returns>
        //public virtual double GetPerimeter()
        //{
        //    return GetDistanceBetweenPoints(points[0], points[1]) + GetDistanceBetweenPoints(points[1], points[2]) +
        //        GetDistanceBetweenPoints(points[2], points[3]) + GetDistanceBetweenPoints(points[3], points[0]);
        //}


        //public virtual void GetSides(out double a, out double b, out double c, out double d)
        //{
        //    a = GetDistanceBetweenPoints(points[0], points[1]);
        //    b = GetDistanceBetweenPoints(points[1], points[2]);
        //    c = GetDistanceBetweenPoints(points[2], points[3]);
        //    d = GetDistanceBetweenPoints(points[3], points[0]);
        //}
        ///// <summary>
        ///// Вычисляет и возвращает значения углов фигуры в градусах 
        ///// </summary>
        ///// <returns>Углы фигуры, по часовой стрелке начиная с нижнего левого угла</returns>
        //public virtual void GetAngles(out double angleA, out double angleB, out double angleC, out double angleD)
        //{
        //    /*
        //     * Делим четырехугольник на два треугольника с помощью диагонали проведенной между A и C (лев. ниж. и прав. верх.)
        //     * Через стороны треугольников, находим косинусы углов треугольников, и выражаем их в градусы через арккосинус от косинуса * 180 * PI
        //     * Затем складываем углы, которые диагональ разделила на два (а именно это углы четырехугольника A и C)
        //     * P.S обозначения сторон треугольников: a1 - верхняя сторона четырехугольника, c1 - левая, b2 - нижняя, c2 - правая
        //     * P.P.S может можно было и лучше, но так понятнее (наверное)
        //     */

        //    double
        //        a1 = GetDistanceBetweenPoints(points[1], points[2]),
        //        diagonal = GetDistanceBetweenPoints(points[0], points[2]),
        //        c1 = GetDistanceBetweenPoints(points[0], points[1]),
        //        b2 = GetDistanceBetweenPoints(points[0], points[3]),
        //        c2 = GetDistanceBetweenPoints(points[2], points[3]);

        //    double angleA1 = Math.Acos((Math.Pow(a1, 2) + Math.Pow(c1, 2) - Math.Pow(diagonal, 2)) / (2d * a1 * c1)) * 180 / Math.PI;
        //    double angleB1 = Math.Acos((Math.Pow(a1, 2) + Math.Pow(diagonal, 2) - Math.Pow(c1, 2)) / (2d * a1 * diagonal)) * 180 / Math.PI;
        //    double angleC1 = Math.Acos((Math.Pow(diagonal, 2) + Math.Pow(c1, 2) - Math.Pow(a1, 2)) / (2d * diagonal * c1)) * 180 / Math.PI;
        //    double angleA2 = Math.Acos((Math.Pow(diagonal, 2) + Math.Pow(c2, 2) - Math.Pow(b2, 2)) / (2d * diagonal * c2)) * 180 / Math.PI;
        //    double angleB2 = Math.Acos((Math.Pow(diagonal, 2) + Math.Pow(b2, 2) - Math.Pow(c2, 2)) / (2d * diagonal * b2)) * 180 / Math.PI;
        //    double angleC2 = Math.Acos((Math.Pow(b2, 2) + Math.Pow(c2, 2) - Math.Pow(diagonal, 2)) / (2d * b2 * c2)) * 180 / Math.PI;

        //    angleA = angleC1 + angleB2;
        //    angleB = angleA1;
        //    angleC = angleB1 + angleA2;
        //    angleD = angleC2;
        //}
    }
}

