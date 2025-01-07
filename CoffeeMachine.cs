using System;

public class CoffeeMachine
{
	public string Brand { get; set; }
	public int WaterCapacity { get; set; }
	public double Price { get; set; }
	private int WaterLevel;
	public CoffeeMachine(string brand, int waterCapacity, double price)
	{
		Brand = brand;
		WaterCapacity = waterCapacity;
		Price = price;
		WaterLevel = 0;
	}
	public virtual void MakeCoffee()
	{
		const string Made = "Here you go, one cup of coffee!!";
		const string NoWater = "There's not enough water!!"; 
		if (WaterLevel >= 1){
			Console.WriteLine(Made);
			WaterLevel--;
		}
		else
		{
			Console.WriteLine(NoWater);
		}
	}
	public void RefillWater()
	{
		const string Refilled = "Water refilled!";
		WaterLevel = WaterCapacity;
		Console.WriteLine(Refilled);
	}
}
