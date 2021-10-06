using System;

class Address
{
    private int index;

    public int Index
    {
        get
        {
            return index;
        }
        set
        {
            index = value;
        }
    }

    private string _country;

    public string country
    {
        get
        {
            return _country;
        }

        set
        {

            _country = value;
        }
    }

    private string _city;

    public string city
    {
        get
        {
            return _city;
        }
        set
        {
            _city = value;
        }
    }

    private string _street;

    public string street
    {
        get
        {
            return _street;
        }

        set
        {
            _street = value;
        }
    }

    private string _house;

    public string house
    {
        get
        {
            return _house;
        }

        set
        {
            _house = value;
        }
    }

    private string _apartment;

    public string apartment
    {
        get
        {
            return _apartment;
        }

        set
        {
            _apartment = value;
        }
    }


}
class Postcode : Address//экземпляр
{
    public void DisplayName()
    {
        Console.WriteLine($"Index: {Index} Country : {country} City : {city} Street : {street} House : {house} Apartment : {apartment}");
    }

}



namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Завдання 1
            /*Postcode code = new Postcode();
            code.Index = 02000; //Задання значень для змінної
            code.country = "Ukraine";
            code.city = "Kiev";
            code.street = "Mikhail Dragomirov ";
            code.house = "4";
            code.apartment = "121";
            code.DisplayName();*/
            //Завдання 2
            /*Rectangle t = new Rectangle(5.0,6.0);*/
            //Завдання 3
            /*Book b = new Book();
            b.All();*/
            //Завдання 5
            /*
            User u = new User();
            u.worksheet(); 
            */
            //Завдання 6          
            /*Console.WriteLine("Which exchage you want to choice");
             Converter converter = new Converter(26.32, 30.36, 0.36);
             Console.ReadLine();
            */
            //Завдання 7
            /*
            Employee emp = new Employee("Петро", "Петров");
            Console.WriteLine("Write name");
            emp.name = Console.ReadLine();
            Console.WriteLine("Write secondname");
            emp.secondname = Console.ReadLine();
            emp.salary(1,1,1.0,1.0);
            Console.ReadLine(); 
            */
            //Завдання 8
            /*
             
            */
            Console.ReadKey();
        }
    }
}
