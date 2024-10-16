using System.Globalization;
using System.Windows.Controls;

namespace M009;

public class LengthValidation : ValidationRule
{
	/// <summary>
	/// Diese Methode empfängt den Wert der Validierung, hier wird jetzt der Wert geprüft
	/// </summary>
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string eingabe = value as string;
		if (eingabe.Length >= 3 && eingabe.Length <= 15)
		{
			//Alles OK
			return ValidationResult.ValidResult;
		}
		else
		{
			//Fehler
			return new ValidationResult(false, "Die Länge der Eingabe muss zw. 3 und 15 Zeichen haben!");
		}
	}
}