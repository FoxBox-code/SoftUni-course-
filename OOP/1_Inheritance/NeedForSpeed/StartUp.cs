namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar adventador = new SportCar(700, 60);

            Car car = new Car(135, 100);

            Motorcycle motor = new Motorcycle(100, 100);
            RaceMotorcycle race = new RaceMotorcycle(100, 100);
            FamilyCar family = new(100, 100);
            car.Drive(10);
            motor.Drive(10);
            race.Drive(10);
            family.Drive(10);
            


            System.Console.WriteLine(car.Fuel);
            System.Console.WriteLine(motor.Fuel);
            System.Console.WriteLine(race.Fuel);
            System.Console.WriteLine(family.Fuel);
        }
    }
}
