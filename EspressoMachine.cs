using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopconcepts
{
    public class EspressoMachine : CoffeeMachine
    {
        public EspressoMachine(string brand, int waterCapacity, double price) : base(brand, waterCapacity, price) {}
        public override void MakeCoffee()
        {
            Console.WriteLine("Here's your Espresso!!");
        }
    }
}
