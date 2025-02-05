#nullable disable
using Microsoft.Maui.Controls.Internals;

namespace Microsoft.Maui.Controls
{
	static class LineHeightElement
	{
		public static readonly BindableProperty LineHeightProperty =
			BindableProperty.Create(nameof(ILineHeightElement.LineHeight), typeof(double), typeof(ILineHeightElement), -1.0d,
									propertyChanged: OnLineHeightChanged);

		static void OnLineHeightChanged(BindableObject bindable, object oldValue, object newValue)
		{
			((ILineHeightElement)bindable).OnLineHeightChanged((double)oldValue, (double)newValue);
		}

	}
}