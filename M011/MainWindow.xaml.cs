using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;

namespace M011;

public partial class MainWindow : Window
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public MainWindow()
	{
		InitializeComponent();

		string json = File.ReadAllText("Personen.json");
		Person[] personen = JsonSerializer.Deserialize<Person[]>(json);
		foreach (Person p in personen)
			Personen.Add(p);
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		//Person im DataGrid finden
		//1. sender zu einem Button casten -> DataContext
		//2. DataGrid über Name ansprechen -> SelectedItem
		Button b = (Button) sender;
		Person p = b.DataContext as Person;
		Personen.Remove(p);
	}
}

///////////////////////////////////////////////////////////////////////////////

[DebuggerDisplay("Person - ID: {ID}, Vorname: {Vorname}, Nachname: {Nachname}, GebDat: {Geburtsdatum.ToString(\"yyyy.MM.dd\")}, Alter: {Alter}, " +
	"Jobtitel: {Job.Titel}, Gehalt: {Job.Gehalt}, Einstellungsdatum: {Job.Einstellungsdatum.ToString(\"yyyy.MM.dd\")}")]
public record Person(int ID, string Vorname, string Nachname, DateTime Geburtsdatum, int Alter, Beruf Job, List<string> Hobbies);

public record Beruf(string Titel, int Gehalt, DateTime Einstellungsdatum);

///////////////////////////////////////////////////////////////////////////////