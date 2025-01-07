using System;

public class CoffeeMachine
{
	public string Brand { get; set; }
	public int WaterCapacity { get; set; }
	public double Price { get; set; }
	public CoffeeMachine(string brand, int waterCapacity, double price)
	{
		Brand = brand;
		WaterCapacity = waterCapacity;
		Price = price;
	}
}
