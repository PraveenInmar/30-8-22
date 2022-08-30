using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusPass
{
	public class Click
	{
		public bool Common(string name)
		{
			if (name.Length == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}
	}
}
