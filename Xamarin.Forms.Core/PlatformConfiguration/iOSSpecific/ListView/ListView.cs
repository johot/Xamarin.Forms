
namespace Xamarin.Forms.PlatformConfiguration.iOSSpecific
{
	//<Curbits>
	using System;
	using System.Collections.Generic;
	using FormsElement = Forms.ListView;

	public static class ListView
	{
		public static readonly BindableProperty RowHeightResolverProperty =
			BindableProperty.Create("RowHeightResolver", typeof(Func<RowSection, float>),
			typeof(FormsElement), null);

		public static readonly BindableProperty ReloadRowsManagerProperty =
			BindableProperty.Create("RowHeightResolver", typeof(ReloadRowsManager),
			typeof(FormsElement), null);

		public static void SetRowHeightResolver(BindableObject element, Func<RowSection, float> value)
		{
			element.SetValue(RowHeightResolverProperty, value);
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> SetRowHeightResolver(this IPlatformElementConfiguration<iOS, FormsElement> config, Func<RowSection, float> rowHeightResolver)
		{
			SetRowHeightResolver(config.Element, rowHeightResolver);

			return config;
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> ReloadRow(this IPlatformElementConfiguration<iOS, FormsElement> config, RowSection rowSection, RowAnimation animation = RowAnimation.Fade)
		{
			// Get the manager
			var reloadRowsManager = GetReloadRowsManager(config);
			reloadRowsManager.ReloadRow(rowSection, animation);

			return config;
		}

		private static ReloadRowsManager GetReloadRowsManager(IPlatformElementConfiguration<iOS, FormsElement> config)
		{
			var reloadRowsManager = (ReloadRowsManager)config.Element.GetValue(ReloadRowsManagerProperty);
			
			if (reloadRowsManager == null)
				config.Element.SetValue(ReloadRowsManagerProperty, new ReloadRowsManager());

			return (ReloadRowsManager)config.Element.GetValue(PlatformConfiguration.iOSSpecific.ListView.ReloadRowsManagerProperty);
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> ReloadRows(this IPlatformElementConfiguration<iOS, FormsElement> config, IList<RowSection> rowSections, RowAnimation animation = RowAnimation.Fade)
		{
			// Get the manager
			var reloadRowsManager = GetReloadRowsManager(config);
			reloadRowsManager.ReloadRows(rowSections, animation);

			return config;
		}
	}
	//</Curbits>
}
