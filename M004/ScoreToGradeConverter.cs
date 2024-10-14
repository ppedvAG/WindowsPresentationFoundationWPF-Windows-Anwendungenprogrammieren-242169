using System.Globalization;
using System.Windows.Data;

namespace M004;

public class ScoreToGradeConverter : IValueConverter
{
	//Quelle -> Ziel
	//Slider -> TextBlock
	//double -> string
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		//value ist der Wert des Sliders
		double d = (double) value;

		//Sehr Gut, Gut, Befriedigend, Ausreichend, Mangelhaft, Ungenügend
		switch (d)
		{
			case >= 90: return "Sehr Gut";
			case >= 80: return "Gut";
			case >= 70: return "Befriedigend";
			case >= 60: return "Ausreichend";
			case >= 50: return "Mangelhaft";
			default: return "Ungenügend";
		}
	}
	
	//Ziel -> Quelle
	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}