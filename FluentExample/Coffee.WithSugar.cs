
namespace FluentExample
{
	public partial class Coffee
	{
		public int RawSugarLevel { get; private set; }

		public string Sugar
		{
			get { return RawSugarLevel + " mg"; }
		}

		public Coffee WithSugar(int milligrams)
		{
			RawSugarLevel = milligrams;
			return this;
		}

		public Coffee AndSugar(int milligrams)
		{
			return WithSugar(milligrams);
		}
	}
}
