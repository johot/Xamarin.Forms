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

		public void ReloadRow(RowSection rowSection, RowAnimation animation = RowAnimation.Fade)
		{
			ReloadRows(new List<RowSection>() { rowSection }, animation);
		}

		public void ReloadRows(IList<RowSection> rowSections, RowAnimation animation = RowAnimation.Fade)
		{
			ReloadRowsRequested?.Invoke(this, new ReloadRowsRequestedEventArgs(rowSections, animation));
		}
	}
}
