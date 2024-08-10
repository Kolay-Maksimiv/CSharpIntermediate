namespace Inheritance
{
    public static class Constructors
    {
        public class Vehicle
        {
            private readonly string _registarionNumber;

            //public Vehicle()
            //{
            //    Console.WriteLine("Vehicle is being initialized.");
            //}

            public Vehicle(string registarionNumber)
            {
                _registarionNumber = registarionNumber;

                Console.WriteLine("Vehicle is being initialized. {0}", registarionNumber);
            }
        }

        public class Car : Vehicle
        {
            public Car(string registarionNumber)
                : base(registarionNumber)
            {
                Console.WriteLine("Car is being initialized. {0}", registarionNumber);
            }
        }
        public static void ConstructorsProgram()
        {
            var car = new Car("XYZ1234");

            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
