using System.Windows;

namespace M000;

public partial class MainWindow : Window
{
	/// <summary>
	/// Schritt 3
	/// </summary>
	public Person person { get; set; } = new Person() { Geschlecht = Geschlecht.W };

	public MainWindow()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Schritt 4
	/// </summary>
	private void Button_Click(object sender, RoutedEventArgs e)
	{
		MessageBox.Show($"{person.Vorname}\n{person.Nachname}\n{person.Geburtsdatum}\n{person.Verheiratet}\n{person.Lieblingsfarbe}\n{person.Geschlecht}", "Die Person", MessageBoxButton.OK);
	}
}