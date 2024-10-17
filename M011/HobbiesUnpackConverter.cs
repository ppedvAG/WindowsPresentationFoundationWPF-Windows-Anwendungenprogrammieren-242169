using System.Globalization;
using System.Windows.Data;

namespace M011;

public class HobbiesUnpackConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		List<string> list = (List<string>) value;
		string s = string.Join(", ", list.Order());
		return s;
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => null;
}