using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M002;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		//Enum.GetValues: Generiert aus einem Enum ein Array, welches alle Enumwerte enthält
		AuswahlTag.ItemsSource = Enum.GetValues<DayOfWeek>();
		MenuWochentage.ItemsSource = Enum.GetValues<DayOfWeek>();
		ListBoxWochentage.ItemsSource = Enum.GetValues<DayOfWeek>();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		MessageBoxResult result = MessageBox.Show("Hallo Welt", "Titel", MessageBoxButton.OKCancel, MessageBoxImage.Information);
		if (result == MessageBoxResult.OK)
		{
			//...
		}
	}

	/// <summary>
	/// Strg + R, R: Member umbenennen
	/// Der entsprechende Member wird überall umbenannt, wo dieser verwendet wird
	/// </summary>
	private void ConfirmClicked(object sender, RoutedEventArgs e)
	{
		Ausgabe.Text = Eingabe.Text;
	}

	private void Eingabe_KeyDown(object sender, KeyEventArgs e)
	{
		if (e.Key == Key.Enter)
		{
			Ausgabe.Text = Eingabe.Text;
		}
	}

	private void Auswahl_Selected(object sender, RoutedEventArgs e)
	{
		AusgabeAuswahl.Text = Auswahl.SelectedItem.ToString();
	}

	private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		AusgabeSlider.Text = e.NewValue.ToString();
	}
}