using System.Windows;

namespace M004;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		//Explicit Binding aktualisieren
		//SliderA.GetBindingExpression(Slider.ValueProperty).UpdateTarget();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		TB.Text = "50";
	}
}