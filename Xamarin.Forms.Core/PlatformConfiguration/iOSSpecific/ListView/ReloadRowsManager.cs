using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Forms.PlatformConfiguration.iOSSpecific
{
	internal class ReloadRowsManager
	{
		public event EventHandler<ReloadRowsRequestedEventArgs> ReloadRowsRequested;

		public void ReloadRows(IList<RowSection> rowSections, object animation = null)
		{
			if (ReloadRowsRequested != null)
				ReloadRowsRequested(this, new ReloadRowsRequestedEventArgs(rowSections, animation));
		}
	}
}
