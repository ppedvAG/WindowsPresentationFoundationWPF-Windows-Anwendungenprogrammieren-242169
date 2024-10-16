using System.ComponentModel;
using System.Windows;

namespace M009;

public partial class MainWindow : Window, IDataErrorInfo
{
	public string DieEingabe { get; set; } = "";

	private string exEingabe = "";

	public string DieEingabeMitException
	{
		get => exEingabe;
		set
		{
			//Wenn eine dieser if's betreten wird, wird die Validierung durchgeführt
			if (!value.All(char.IsLetter))
			{
				throw new ArgumentException("Die Eingabe darf nur aus Buchstaben bestehen!");
			}

			if (value.Length < 3 || value.Length > 15)
			{
				throw new ArgumentException("Die Länge der Eingabe muss zw. 3 und 15 Zeichen haben!");
			}

			exEingabe = value;
		}
	}

	/// <summary>
	/// Kann ignoriert werden
	/// </summary>
	public string Error => throw new NotImplementedException();

	/// <summary>
	/// Indexer
	/// 
	/// Grundkomponente von Listen
	/// Ermöglicht, ein Objekt mit [...] ansprechen zu können
	/// 
	/// List<int> zahlen = [1, 2, 3];
	/// int x = zahlen[0]; <-- Nur möglich mit this[...]
	/// </summary>
	public string this[string fieldName]
	{
		get
		{
			//Name der Variable, welche validiert wird
			switch (fieldName)
			{
				//Bei jedem Case die Validierungsregeln einbauen
				case nameof(DieEingabe):
					if (!DieEingabe.All(char.IsLetter))
						return "Die Eingabe darf nur aus Buchstaben bestehen!";

					if (DieEingabe.Length < 3 || DieEingabe.Length > 15)
						return "Die Länge der Eingabe muss zw. 3 und 15 Zeichen haben!";

					break;

				//Bei jedem Case die Validierungsregeln einbauen
				case nameof(DieEingabeMitException):
					if (!DieEingabeMitException.All(char.IsLetter))
						return "Die Eingabe darf nur aus Buchstaben bestehen!";

					if (DieEingabeMitException.Length < 3 || DieEingabeMitException.Length > 15)
						return "Die Länge der Eingabe muss zw. 3 und 15 Zeichen haben!";

					break;
			}

			return null; //Wenn dieses Stück Code erreich wird, gibt es keine Validierungsfehler
		}
	}

	public MainWindow()
	{
		InitializeComponent();

	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{

	}
}