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

		public bool HasCream { get { return _cream; } }

		public Coffee WithCream()
		{
			_cream = true;
			return this;
		}
	}
}
