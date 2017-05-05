using System;
using System.Collections.Generic;

namespace Xamarin.Forms
{
	public class ReloadRowsRequestedEventArgs : EventArgs
	{
		public ReloadRowsRequestedEventArgs(IList<RowSection> rowSections, object animation = null)
		{
			Animation = animation;
			RowSections = rowSections;
		}

		public IList<RowSection> RowSections { get; private set; }
		public object Animation { get; set; }
	}
}