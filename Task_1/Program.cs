using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.           В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:

-       метод получает входным параметром переменную типа double;

-       метод возвращает значение типа double, которое является результатом вычисления.

 

Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:

-       длину окружности по формуле D = 2 * π* R;

-       площадь круга по формуле S = π* R²;

-       объем шара. Формула V = 4/3 * π * R³.



Методы должны быть объявлены как статические.*/

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение радиуса");
            double radius = Convert.ToDouble(Console.ReadLine());

            Func<double, double> func = CircleLength;
            double circleLength = func.Invoke(radius);

            func = CircleArea;
            double circleArea = func.Invoke(radius);

            func = SphereVolume;
            double sphereVolume = func.Invoke(radius);

            Console.WriteLine("Длина окружности - {0}\nПлощадь окружности - {1}\nОбъём шара - {2}",circleLength, circleArea, sphereVolume);

            Console.ReadKey();
        }

        static double CircleLength(double radius) => 2 * Math.PI * radius;
        static double CircleArea(double radius) => Math.PI * radius * radius;
        static double SphereVolume(double radius) => 4.0 / 3 * Math.PI * radius * radius * radius;
    }
}
