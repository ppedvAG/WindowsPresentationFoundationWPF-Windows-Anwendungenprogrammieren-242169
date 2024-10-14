using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace M004;

public class FourValueToMarginConverter : IMultiValueConverter
{
	public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
	{
		//In values kommen die Werte hinein, in der Reihenfolge in dem die Bindings im XAML definiert sind
		//< Binding ElementName = "LSlider" Path = "Value" />
		//< Binding ElementName = "TSlider" Path = "Value" />
		//< Binding ElementName = "RSlider" Path = "Value" />
		//< Binding ElementName = "BSlider" Path = "Value" />
		double[] d = new double[values.Length];
		for (int i = 0; i < values.Length; i++)
		{
			d[i] = (double) values[i];
		}

		return new Thickness(d[0], d[1], d[2], d[3]);
	}

	public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}