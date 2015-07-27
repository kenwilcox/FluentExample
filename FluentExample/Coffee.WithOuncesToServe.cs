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

		public int OuncesToServe { get { return _ounces; } }

		public Coffee WithOuncesToServe(int ounces)
		{
			_ounces = ounces;
			return this;
		}
	}
}
