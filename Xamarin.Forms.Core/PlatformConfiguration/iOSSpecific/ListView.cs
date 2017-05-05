
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
			typeof(ListView), null);

		public static void SetRowHeightResolver(BindableObject element, Func<RowSection, float> value)
		{
			element.SetValue(RowHeightResolverProperty, value);
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> SetRowHeightResolver(this IPlatformElementConfiguration<iOS, FormsElement> config, Func<RowSection, float> rowHeightResolver)
		{
			SetRowHeightResolver(config.Element, rowHeightResolver);

			return config;
		}

		public static IPlatformElementConfiguration<iOS, FormsElement> ReloadRows(this IPlatformElementConfiguration<iOS, FormsElement> config, IList<RowSection> rowSections, object animation = null)
		{
			config.Element.ReloadRows(rowSections, animation);

			return config;
		}
	}
	//</Curbits>
}
