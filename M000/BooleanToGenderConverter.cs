using System.Globalization;
using System.Windows.Data;

namespace M000;

/// <summary>
/// Schritt 5
/// </summary>
public class BooleanToGenderConverter : IValueConverter
{
	//Klasse -> GUI
	//Geschlecht -> bool
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		Geschlecht g = (Geschlecht) value;
		Geschlecht p = (Geschlecht) parameter;
		if (g == p)
			return true;
		else
			return false;

		//return (Geschlecht) value == (Geschlecht) parameter;
	}

	//GUI -> Klasse
	//bool -> Geschlecht
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		bool b = (bool) value;
		if (b)
			return (Geschlecht) parameter;
		return Binding.DoNothing;
	}
}