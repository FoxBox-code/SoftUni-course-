namespace RawData;

public class Startup
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] carProps = Console.ReadLine()
                .Split(" ");

            Car car = new Car(
                carProps[0],
                int.Parse(carProps[1]),//speed
                int.Parse(carProps[2]),//power
                int.Parse(carProps[3]),//wieght
                carProps[4],//tipe
                double.Parse(carProps[5]),//tire Pressure
                int.Parse(carProps[6]),
                double.Parse(carProps[7]),
                int.Parse(carProps[8]),
                double.Parse(carProps[9]),
                int.Parse(carProps[10]),
                double.Parse(carProps[11]),
                int.Parse(carProps[12]));

            cars.Add(car);

                


        }
        string command = Console.ReadLine();
        string[] filterModels;


        if (command == "fragile")
        {
            filterModels = cars
                .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(p => p.Pressure < 1))
                .Select(c => c.Model)
                .ToArray();
        }
        else
        {
            filterModels = cars
                .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToArray();
        }
        
        Console.WriteLine(String.Join(Environment.NewLine , filterModels));
    }
}