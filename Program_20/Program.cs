using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_20
{
    internal class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.Title = "ЗАДАНИЕ 20. ДЕЛЕГАТЫ";

            MyDelegate myDelegate = new MyDelegate (LCircle);
            myDelegate += SCircle;
            myDelegate += VCircle;
            Console.Beep();
            Console.Write("Введите радиус окружности: ");
            double r = double.Parse(Console.ReadLine());

            myDelegate?.Invoke(r);
            Console.ReadKey();
        }

        public static double LCircle(double R)
        {
            double D = 2 * Math.PI * R;
            Console.WriteLine($"Длина окружности равна: {D:0.00} ");
            return D;
        }
        public static double SCircle(double R)
        {
            double S = Math.PI * Math.Pow(R, 2);
            Console.WriteLine($"Площадь круга равна: {S:0.00}");
            return S;
        }
        public static double VCircle(double R)
        {
            double V = 4 / 3 * Math.PI * Math.Pow(R, 3);
            Console.WriteLine($"Объем шара равен: {V:0.00}");
            return V;
        }
    }
}

//1.В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:

//-метод получает входным параметром переменную типа double;

//-метод возвращает значение типа double, которое является результатом вычисления.



//Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:

//-длину окружности по формуле D = 2 * π* R;

//-площадь круга по формуле S = π* R²;

//-объем шара.Формула V = 4 / 3 * π * R³.



//Методы должны быть объявлены как статические.