using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace M005;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	private int zaehler;

	/// <summary>
	/// Die Variable MUSS ein Property sein (get; set;)
	/// </summary>
	public int Zaehler
	{
		get => zaehler;
		set
		{
			zaehler = value;
			Notify(); //nameof(Zaehler) -> "Zaehler"
		}
	}

	//////////////////////////////////////////////////////////////////////////////////////

	public ObservableCollection<int> Zahlen { get; set; } = [1, 2, 3, 4, 5];

	public MainWindow()
	{
		InitializeComponent();
		this.DataContext = this; //Das Fenster sieht sich selbst
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Zaehler++;
		Zahlen[0]++;
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		Zahlen.Add(Zahlen.Last() + 1);
	}

	//////////////////////////////////////////////////////////////////////////////////////

	public event PropertyChangedEventHandler? PropertyChanged;

	//public void Notify(string propName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

	public void Notify([CallerMemberName] string propName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
}