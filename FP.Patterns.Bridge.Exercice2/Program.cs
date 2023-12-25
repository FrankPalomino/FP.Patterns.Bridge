using FP.Patterns.Bridge.Exercice2;

IAdditionalFeatures extraCapacity = new ExtraCapacity();
IAdditionalFeatures ledLights = new LEDLights();

IVehicle car = new Car(extraCapacity);
IVehicle scooter = new ElectricScooter(ledLights);
IVehicle bicycle = new Bicycle(ledLights);

car.ShowDetails();
scooter.ShowDetails();
bicycle.ShowDetails();