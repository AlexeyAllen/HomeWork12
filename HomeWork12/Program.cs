using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        // Разработать статический класс для работы с окружностью.
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите вид расчета");
            Console.WriteLine("(1) Определение длины окружности по заданному радиусу");
            Console.WriteLine("(2) Определение площади круга по заданному радиусу");
            Console.WriteLine("(3) Определение принадлежности точки кругу");
            byte option = Convert.ToByte(Console.ReadLine());
            double radius;
            double coordX;
            double coordY;
            switch (option)
            {
                case 1:
                    Console.Write("Для определения длины окружности введите значение радиуса окружности r = ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    circleCalcs.CircleLength(radius);
                    break;
                case 2:
                    Console.Write("Для определения площади круга по заданному радиусу введите значение радиуса окружности r = ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    circleCalcs.CircleArea(radius);
                    break;
                case 3:
                    Console.WriteLine("Для определения принадлежности точки А кругу введите следующие значения");
                    Console.Write("Радиус круга r = ");
                    radius = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Координату X точки А = ");
                    coordX = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Координату Y точки А = ");
                    coordY = Convert.ToDouble(Console.ReadLine());
                    circleCalcs.PointBelong(radius, coordX, coordY);
                    break;
            }
            Console.ReadKey();
        }
    }

    static class circleCalcs
    {
        public static void CircleLength(double radius)
        {
            double circleLength = 2 * Math.PI * radius;
            Console.WriteLine("Значение длины окружности равно {0:f2}", circleLength);
        }
        public static void CircleArea(double radius)
        {
            double circleArea = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Значение площади окружности равно {0:f2}", circleArea);
        }
        public static void PointBelong(double radius, double coordX, double coordY)
        {
            double pointRadius = Math.Sqrt(Math.Pow(coordX, 2) + Math.Pow(coordY, 2));
            if (pointRadius < radius)
            {
                Console.WriteLine("Точка А расположена в пределах круга");
            }
            else
            {
                Console.WriteLine("Точка А расположена вне границ круга");
            }
        }
    }
}
