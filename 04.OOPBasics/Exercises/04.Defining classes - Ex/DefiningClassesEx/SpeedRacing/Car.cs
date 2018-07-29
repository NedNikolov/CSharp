using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumation;
    private double distanceTraveled;

    public Car(string model, double fuelAmount, double fuelConsumation)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumation = fuelConsumation;
        this.distanceTraveled = 0;
    }

    public string Model => this.model;

    public void Drive(int distance)
    {
        if (this.fuelConsumation * distance <= this.fuelAmount)
        {
            this.distanceTraveled += distance;
            this.fuelAmount -= this.fuelConsumation * distance;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }

    public override string ToString()
    {
        return $"{this.model} {this.fuelAmount:f2} {this.distanceTraveled}";
    }
}

