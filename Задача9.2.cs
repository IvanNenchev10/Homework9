using System;
using System.Collections;
namespace Задача9._3
{
    class Program
    {
        abstract class Vehicle
        {
            
            public string Name
            {
                set { Name = value; }
                get { return Name; }
            }
            public  int YearOfProduction
            {
                set { YearOfProduction = value; }
                get { return YearOfProduction; }
            }
            public  string RegistrationNumber
            {
                set { RegistrationNumber = value; }
                get { return RegistrationNumber; }
            }
            public  string Engine
            {
                set { Engine = value; }
                get { return Engine; }
            }
            public abstract void Drive(int speed);
            public abstract int GetYears();
        }
        class Car:Vehicle
         {
           
            public override void Drive(int speed)
            {
                Console.WriteLine("The speed of the car is:{0}", speed);
            }
            public override int GetYears()
            {
                Console.Write("The age of the vehicle is:  ");
                return 2019 - YearOfProduction;
            }
            public static  void StartTurbo()
            {
                Console.WriteLine("Turbo is started");
            }
            public static  int NumberOfTyres(int tyres)
            {
                Console.Write("Number of tyres is:  ");
                return tyres;
            }
        }
        class Motor : Vehicle
        {
            public override void Drive(int speed)
            {
                Console.WriteLine("Speed of the motor is:{0}", speed);
            }
            public override int GetYears()
            {
                Console.Write("Years of the Motor: ");
                return 2019 - YearOfProduction;
            }
        }
        static void Main()
        {
            Vehicle car = new Car();
            car.Name = "Mazda";
            car.YearOfProduction = 2019;
            car.RegistrationNumber = "PA9616KN";
            car.Engine = "SkyActive";
            Console.WriteLine("Car Name:{0}", car.Name);
            Console.WriteLine("Car YearOfProduction:{0}", car.YearOfProduction);
            Console.WriteLine("Car RegistrationNumber:{0}", car.RegistrationNumber);
            Console.WriteLine("Car Engine:{0}", car.Engine);
            car.Drive(100);
            Console.WriteLine("{0}", car.GetYears());
            Car.StartTurbo();
            Console.WriteLine("{0}", Car.NumberOfTyres(4));
            Console.WriteLine();
            Vehicle motor = new Motor();
            motor.Name = "Suzuki";
            motor.YearOfProduction = 2015;
            motor.RegistrationNumber = "CA1914BP";
            motor.Engine = "Suzuki";
            Console.WriteLine("Motor Name:{0}", motor.Name);
            Console.WriteLine("Motor YearOfProduction:{0}", motor.YearOfProduction);
            Console.WriteLine("Motor RegistrationNumber:{0}", motor.RegistrationNumber);
            Console.WriteLine("Motor Engine:{0}", motor.Engine);
            motor.Drive(50);
            Console.WriteLine("{0}",motor.GetYears());
            

        }
    }
}
