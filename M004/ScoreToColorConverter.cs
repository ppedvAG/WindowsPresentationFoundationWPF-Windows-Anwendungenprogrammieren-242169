﻿using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace M004;

public class ScoreToColorConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		double d = (double) value;
		switch (d)
		{
			case >= 90: return new SolidColorBrush(Colors.Green);
			case >= 80: return new SolidColorBrush(Colors.LightGreen);
			case >= 70: return new SolidColorBrush(Colors.Yellow);
			case >= 60: return new SolidColorBrush(Colors.Orange);
			case >= 50: return new SolidColorBrush(Colors.DarkOrange);
			default: return new SolidColorBrush(Colors.Red);
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}