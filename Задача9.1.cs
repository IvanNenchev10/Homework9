using System;

namespace Task9._1
{
    class Program
    {
        public interface I1
        {
            string Name { get; set; }
            int YearOfProduction { get; set; }
            string RegistrationNumber { get; set; }
            string Engine { get; set; }
            void Drive(int speed);
            int GetYears();

        }
        class Car : I1
        {
            private string name;
            private int yearOfProduction;
            private string registrationNumber;
            private string engine;
            public Car()
            {
                name = null;
                yearOfProduction = 0;
                registrationNumber = null;
                engine = null;
            }
            public Car(string name, int yearOfProduction, string registrationNumber, string engine)
            {
                this.name = name;
                this.yearOfProduction = yearOfProduction;
                this.registrationNumber = registrationNumber;
                this.engine = engine;
            }
            public string Name
            {
                set { name = value; }
                get { return name; }
            }
            public int YearOfProduction
            {
                set { yearOfProduction = value; }
                get { return yearOfProduction; }
            }
            public string RegistrationNumber
            {
                set { registrationNumber = value; }
                get { return registrationNumber; }
            }
            public string Engine
            {
                set { engine = value; }
                get { return engine; }
            }
            public void Drive(int speed)
            {
                Console.WriteLine(" Speed of the vehicle is  {0}km/h", speed);
            }
            public int GetYears()
            {
                Console.Write("Vehicle age is:  ");
                return 2019 - YearOfProduction;
            }
            public int NumberOfTyres(int tyres)
            {
                Console.Write("Number of tyres is  ");
                return tyres;
            }
            public void DriveTurbo()
            {
                Console.WriteLine("Turbo is on!");
            }
        }
        class Motor : Car
        {
            public Motor(string name, int yearOfProduction, string registrationNumber, string engine) : base(name, yearOfProduction, registrationNumber, engine) { }

        }
        static void Main()
        {
            Car car1 = new Car("Mazda", 2010, "PA9616KN", "SkyActive");
            I1 I = car1;
            Console.WriteLine("Name of the car:{0}", I.Name);
            Console.WriteLine("Year Of Production:{0}", I.YearOfProduction);
            Console.WriteLine("RegistrationNumber:{0}", I.RegistrationNumber);
            Console.WriteLine("Engine:{0}", I.Engine);
            I.Drive(100);
            Console.WriteLine("{0}", I.GetYears());
            Console.WriteLine("{0}", car1.NumberOfTyres(4));
            car1.DriveTurbo();
            I = new Motor("Yamaha", 2009, "CO1416BP", "Yamaha");
            Console.WriteLine("Name of the motor:{0}", I.Name);
            Console.WriteLine("Year of Production:{0}", I.YearOfProduction);
            Console.WriteLine("RegistrationNumber:{0}", I.RegistrationNumber);
            Console.WriteLine("Engine:{0}", I.Engine);
            I.Drive(50);
            Console.WriteLine("{0}", I.GetYears());
        }
    }
}
