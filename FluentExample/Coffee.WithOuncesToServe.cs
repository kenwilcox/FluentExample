
namespace FluentExample
{
	public partial class Coffee
	{
		public int RawOunces { get; private set; }

		public string Ounces { get { return RawOunces + " oz"; } }

		public Coffee WithOuncesToServe(int ounces)
		{
			RawOunces = ounces;
			return this;
		}
	}
}
