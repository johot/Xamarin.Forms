using System;
using System.Collections.Generic;

namespace Xamarin.Forms
{
	public class ReloadRowsRequestedEventArgs : EventArgs
	{
		public ReloadRowsRequestedEventArgs(IList<RowSection> rowSections, RowAnimation animation =  RowAnimation.Automatic)
		{
			Animation = animation;
			RowSections = rowSections;
		}

		public IList<RowSection> RowSections { get; private set; }
		public RowAnimation Animation { get; set; }
	}
	
	public enum RowAnimation
	{
		Fade = 0,
		Right = 1,
		Left = 2,
		Top = 3,
		Bottom = 4,
		None = 5,
		Middle = 6,
		Automatic = 100
	}
}