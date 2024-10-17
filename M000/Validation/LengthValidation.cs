using System.Globalization;
using System.Windows.Controls;

namespace M000.Validation;

public class LengthValidation : ValidationRule
{
	/// <summary>
	/// Diese Methode empfängt den Wert der Validierung, hier wird jetzt der Wert geprüft
	/// </summary>
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string eingabe = value as string;
		if (eingabe == null)
		{
			return new ValidationResult(false, "Bitte gib einen Wert ein.");
		}
		if (eingabe.Length > 15)
		{
			//Fehler
			return new ValidationResult(false, "Die Eingabe darf nicht länger als 15 Zeichen sein!");
		}
		return ValidationResult.ValidResult;
	}
}