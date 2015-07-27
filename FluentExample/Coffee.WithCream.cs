using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentExample
{
	public partial class Coffee
	{
		private bool _cream;

		public bool RawCream { get { return _cream; } }

		public string Cream { get { return _cream ? "Yes" : "No"; } }

		public Coffee WithCream()
		{
			_cream = true;
			return this;
		}
	}
}
