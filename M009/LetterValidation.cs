using System.Globalization;
using System.Windows.Controls;

namespace M009;

public class LetterValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string eingabe = value as string;
		if (eingabe.All(char.IsLetter)) //Prüfe, ob alle Zeichen in dem string Buchstaben sind (a-z, A-Z)
		{
			//Alles OK
			return ValidationResult.ValidResult;
		}
		else
		{
			return new ValidationResult(false, "Die Eingabe darf nur aus Buchstaben bestehen!");
		}
	}
}