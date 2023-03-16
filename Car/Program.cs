using Car;

Car.Car car = new Car.Car("Toyota", "Prius", 10, 50);
Console.WriteLine(car.Make + " - " + car.Model);
Console.WriteLine(car.GasTankLevel);
car.Drive(50);
Console.WriteLine(car.GasTankLevel);