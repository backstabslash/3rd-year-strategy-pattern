namespace strategyexample
{
    public class Program
    {
        static void Main(string[] args)
        {
            SportsCar spc1 = new SportsCar();
            TeslaCar tec1 = new TeslaCar();
            TeslaCar tec2 = new TeslaCar();
            tec2.SetControlBehavior(new ManualDrive());
            tec2.SetChargeBehavior(new GasolineCharge());
            ToyCar toc1 = new ToyCar();
            ToyCar toc2 = new ToyCar();
            toc2.SetChargeBehavior(new ElectroCharge());
            toc2.SetBeepBehavior(new HonkBeep());
            Car[] cars = { spc1, tec1, tec2, toc1, toc2 };
            foreach(Car car in cars)
            {
                car.Display();
                car.Perform();
                car.Display();
                Console.WriteLine();
            }
        }
    }
}