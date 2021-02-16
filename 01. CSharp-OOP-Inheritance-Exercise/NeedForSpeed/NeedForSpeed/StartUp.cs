using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car(150, 100);

            car.Drive(10);

            FamilyCar famCar = new FamilyCar(75, 100);

            famCar.Drive(10);

            SportCar sportCar = new SportCar(350, 1000);

            sportCar.Drive(10);

            RaceMotorcycle race = new RaceMotorcycle(450, 500);

            race.Drive(10);

            CrossMotorcycle cross = new CrossMotorcycle(150, 350);

            cross.Drive(10);

        }
    }
}
