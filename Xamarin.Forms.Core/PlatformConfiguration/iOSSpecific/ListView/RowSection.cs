using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms
{
	public class RowSection
	{
		public RowSection(int row, int section = 0)
		{
			Row = row;
			Section = section;
		}

		public int Row { get; set; }
		public int Section { get; set; }
	}
}
