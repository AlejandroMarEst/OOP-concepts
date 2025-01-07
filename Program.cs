using System;
namespace oopconcepts
{
    public class Program
    {
        public static void Main()
        {
            CoffeeMachine MyCoffeeMachine = new CoffeeMachine("Nesspresso",60,69.99);
            CoffeeMachine YourCoffeeMachine = new CoffeeMachine("Philips", 80, 99.99);

            const string CoffeeDisplay = "{0}, {1}, {2}";
            Console.WriteLine(CoffeeDisplay, YourCoffeeMachine.Brand, YourCoffeeMachine.WaterCapacity, YourCoffeeMachine.Price);
            Console.WriteLine(CoffeeDisplay, MyCoffeeMachine.Brand, MyCoffeeMachine.WaterCapacity, MyCoffeeMachine.Price);
        }
    }
}