using System.Windows;
using System.Windows.Controls;

namespace M000;

public partial class Counter : UserControl
{
	/// <summary>
	/// DependencyProperty: Wird für Bindings benötigt
	/// 
	/// propdp: DependencyProperty + Variable erzeugen
	/// </summary>
	public int Zahl
	{
		get => (int) GetValue(ZahlProperty);
		set => SetValue(ZahlProperty, value);
	}

	public static readonly DependencyProperty ZahlProperty =
		DependencyProperty.Register
		(
			nameof(Zahl), //Name der Variable hinter dem DP
			typeof(int), //Typ der Variable
			typeof(Counter), //Typ des UserControls
			new PropertyMetadata(0) //Standardwert setzen
		);

	/// <summary>
	/// Aufgaben:
	/// - GUI designen
	/// - Die Backend Variable erstellen (DependencyProperty)
	/// - Den Buttons Funktionen geben
	/// </summary>
	public Counter() => InitializeComponent();

	private void CounterUp(object sender, RoutedEventArgs e)
	{
		Zahl++;
	}

	private void CounterDown(object sender, RoutedEventArgs e)
	{
		Zahl--;
	}
}