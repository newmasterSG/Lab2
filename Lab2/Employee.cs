using System;

namespace Lab2
{
    class Employee
    {
        public string name;
        public string secondname;

        public Employee(string name, string secondname)
        {
            this.name = name;
            this.secondname = secondname;
        }

        public void salary(int position, int experience, double salary, double tax)
        {
            Console.WriteLine("We have three positions and types of experience");
            Console.WriteLine("Choice position");
            position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choice experience");
            experience = Convert.ToInt32(Console.ReadLine());
            if (position == 1 & experience <= 3)
            {
                Console.WriteLine("You junior programmer");
                salary = ((50002.05 + 78950.61) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your tax: {tax}");
            }
            if (position == 2 & experience <= 3)
            {
                Console.WriteLine("You junior graphic designer");
                salary = ((53000 + 23000) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your tax: {tax}");
            }
            if (position == 3 & experience >= 10)
            {
                Console.WriteLine("You senior programmer");
                salary = ((52633.74 + 82503.39) / 2);
                tax = salary * 0.18;
                Console.WriteLine($"Your salary: {salary}");
                Console.WriteLine($"Your salary: {tax}");
            }
            Console.WriteLine($"You {name} {secondname} and your posiotion {position}. Your salary: {salary} and your tax: {tax}");

        }




    }
}
