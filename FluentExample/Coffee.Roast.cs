
namespace FluentExample
{
	public partial class Coffee
	{
		public enum CoffeeRoast
		{
			Light,
			Medium,
			Dark
		}

		public CoffeeRoast RoastType { get; private set; }

		public Coffee WithRoast(CoffeeRoast roast)
		{
			RoastType = roast;
			return this;
		}
	}
}
