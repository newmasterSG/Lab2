using System;

namespace Lab2
{
    class Rectangle
    {
        public double side1; // Перша сторона

        public double side2;// Друга сторона
        public Rectangle(double side1, double side2) //Конструкт
        {
            this.side1 = side1; // ініціалізація першої сторони
            Console.WriteLine("Введите первую сторону");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите вторую сторону");
            this.side2 = side2; // ініціалізація другою сторони
            side2 = Convert.ToDouble(Console.ReadLine());
            double AreaCalculator = side1 * side2;
            Console.WriteLine($"Ваша площадь = {AreaCalculator} ");

            double PerimeterCalculator = 2 * (side1 + side2);
            Console.WriteLine($"Ваш периметр = {PerimeterCalculator} ");
        }


        private double AreaCalculator;

        //Властивість для площаді
        public double Area
        {
            get // Нужно для читання змінної
            {
                return AreaCalculator;
            }
        }

        private double PerimeterCalculator;

        //Властивість для периметра 
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator;// Нужно для читання змінної
            }
        }


    }
}
