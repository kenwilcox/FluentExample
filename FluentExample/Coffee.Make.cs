using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentExample
{
	public partial class Coffee
	{
		public static Coffee Make
		{
			get
			{
				return new Coffee();
			}
		}
	}
}
