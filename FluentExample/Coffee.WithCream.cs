
namespace FluentExample
{
	public partial class Coffee
	{
		public bool RawCream { get; private set; }

		public string Cream { get { return RawCream ? "Yes" : "No"; } }

		public Coffee WithCream()
		{
			RawCream = true;
			return this;
		}
	}
}
