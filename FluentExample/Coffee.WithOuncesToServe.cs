using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentExample
{
	public partial class Coffee
	{
		private int _ounces;

		public int RawOunces { get { return _ounces; } }

		public string Ounces { get { return _ounces + " oz"; } }

		public Coffee WithOuncesToServe(int ounces)
		{
			_ounces = ounces;
			return this;
		}
	}
}
