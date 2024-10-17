using System.Globalization;
using System.Windows.Controls;
using System.Windows.Media;

namespace M000.Validation;

public class ColorValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		if (value is Color c)
		{
			if (c == Color.FromArgb(0, 0, 0, 0))
			{
				return new ValidationResult(false, "Wähle eine Farbe aus.");
			}
		}

		return ValidationResult.ValidResult;
	}
}