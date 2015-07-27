using System;

namespace FluentExample
{
	class Program
	{
		static void Main()
		{
			var myMorningCoffee = Coffee.Make.WithRoast(Coffee.CoffeeRoast.Dark).WithCream().AndSugar(100).WithOuncesToServe(16);
			Console.WriteLine("MyMorningCoffee = {0}", myMorningCoffee);

			// But you still have access to the non pretty ones
			Console.WriteLine("{0}", myMorningCoffee.RawCream);
			Console.WriteLine("{0}", myMorningCoffee.RawOunces);
			Console.WriteLine("{0}", myMorningCoffee.RawSugarLevel);
		}
	}
}
