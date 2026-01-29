namespace CarManufacturer

{

    public class StartUp

    {

        static void Main()

        {
            Engine v12natural = new Engine(800, 4);
            Tire[] tires = new Tire[4]
            {
                new Tire(2000,20),
                new Tire(2000,20),
                new Tire(2000,20),
                new Tire(2000,20)

            };
            Car car = new Car("BMW","X3",2006,60,10, v12natural , tires);
            Car car2 = new Car();




            car.PrintInput();
            car.Model = "Arteon";
            car2.PrintInput();
            car.PrintInput();




        }

    }

}