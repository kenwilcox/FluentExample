using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		private CoffeeRoast _roast;

		public CoffeeRoast RoastType { get { return _roast; } }

		public Coffee WithRoast(CoffeeRoast roast)
		{
			_roast = roast;
			return this;
		}
	}
}
