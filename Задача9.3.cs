using System;
using System.Collections;
namespace Задача9._3
{
    class Program
    {
        class Car:IComparable
        {
            private string mark;
            private int yearOfProduction;
            public Car()
            {
                mark = null;
                yearOfProduction = 0;
            }
            public Car(string mark,int yearOfProduction)
            {
                this.mark = mark;
                this.yearOfProduction = yearOfProduction;
            }
            public string Mark
            {
                set { mark = value; }
                get { return mark; }
            }
            public int YearOfProduction
            {
                set { yearOfProduction = value; }
                get { return yearOfProduction; }
            }
            public int CompareTo(object obj)
            {
               if(!(obj is Car))
                {
                    throw new ArgumentException("Object is not a car");
                }
                Car c = obj as Car;
                return yearOfProduction.CompareTo(c.yearOfProduction);
            }
        }
        class CarComparer:IComparer
        {
            private int option;
            public CarComparer()
            {
                option = 0;
            }
            public CarComparer(int option)
            {
                this.option = option;
            }
            public static void Menu()
            {
                Console.WriteLine("Choose option for comparison:");
                Console.WriteLine("Option 1:Compare by Year Ascending");
                Console.WriteLine("Option 2:Compare by Year Descending");
                Console.WriteLine("Option 3:Compare by Mark Ascending");
                Console.WriteLine("Option 4:Compare by Mark Descending");
            }
            public int Compare(object a,object b)
            {
                if(!(a is Car || b is Car))
                {
                    throw new ArgumentException("Invalid arguments");
                }
                Car c1 = a as Car;
                Car c2 = b as Car;
                switch(option)
                {
                    case 1:
                        return c1.YearOfProduction.CompareTo(c2.YearOfProduction);
                    case 2:
                        return c2.YearOfProduction.CompareTo(c2.YearOfProduction);
                    case 3:
                        return c1.Mark.CompareTo(c2.Mark);
                    case 4:
                        return c2.Mark.CompareTo(c1.Mark);
                    default:
                        break;
                }
                return c1.YearOfProduction.CompareTo(c2.YearOfProduction);
            }
        }
        static void Main()
        {
            Car car1 = new Car("Mazda", 2019);
            Car car2 = new Car("Honda", 2017);
            Car car3 = new Car("Lada", 1983);
            Car[] cars = new Car[3] { car1, car2, car3 };
            for(int i=0;i<cars.Length;i++)
            {
                Console.WriteLine("Car {0} Mark:{1}", i + 1, cars[i].Mark);
                Console.WriteLine("Car {0} YearOfProduction:{1}", i + 1, cars[i].YearOfProduction);
                Console.WriteLine();
            }
            Array.Sort(cars);
            Console.WriteLine("Array after sorting");
            Console.WriteLine();
            for(int i=0;i<cars.Length;i++)
            {
                Console.WriteLine("Car {0} Mark:{1}", i + 1, cars[i].Mark);
                Console.WriteLine("Car {0} YearOfProduction:{1}", i + 1, cars[i].YearOfProduction);
                Console.WriteLine();
            }
            CarComparer.Menu();
            Console.WriteLine("Enter option:");
            int option = int.Parse(Console.ReadLine());
            CarComparer CC = new CarComparer(option);
            Array.Sort(cars, CC);
            for(int i=0;i<cars.Length;i++)
            {
                Console.WriteLine("Car {0} Mark:{1}", i + 1, cars[i].Mark);
                Console.WriteLine("Car {0} YearOfProduction:{1}", i + 1, cars[i].YearOfProduction);
                Console.WriteLine();
            }

        }
    }
}
