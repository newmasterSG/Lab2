using System;

namespace Lab2
{
    class Converter
    {
        public double Hryvnia;
        private double HryvniaCal
        {
            get
            {
                return Hryvnia;
            }
            set
            {
                this.Hryvnia = value;
            }
        }
        public double usd;

        public double eur;

        public double rub;


        public Converter(double Usd, double Eur, double Rub)
        {
            int choice;
            int number;
            choice = Convert.ToInt32(Console.ReadLine());
            this.usd = Usd;
            this.eur = Eur;
            this.rub = Rub;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You choice a convert USD to Hryvnia");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = number * Usd;
                    Console.WriteLine($"You'll get {HryvniaCal}");
                    break;

                case 2:
                    Console.WriteLine("You choice a convert Eur to Hryvnia");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = number * Eur;
                    Console.WriteLine($"You'll get {HryvniaCal}");
                    break;

                case 3:
                    Console.WriteLine("You choice a convert Rub to Hryvnia");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    HryvniaCal = number * Rub;
                    Console.WriteLine($"You'll get {HryvniaCal}");
                    break;

                case 4:
                    Console.WriteLine("You choice a convert Hryvnia to Rub");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    double Rubl = number / 0.36;
                    Console.WriteLine($"You'll get {Rubl}");
                    break;

                case 5:
                    Console.WriteLine("You choice a convert Hryvnia to USD");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    double UsD = number / 26.32;
                    Console.WriteLine($"You'll get {UsD}");
                    break;

                case 6:
                    Console.WriteLine("You choice a convert Hryvnia to Eur");
                    Console.WriteLine("Please write numbers");
                    number = Convert.ToInt32(Console.ReadLine());
                    double EuR = number / 30.36;
                    Console.WriteLine($"You'll get {EuR}");
                    break;

                default:
                    Console.WriteLine("Try Again");
                    break;
            }
        }


    }
}
