using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using M013.Model;
using M013.Utility;

namespace M013.ViewModel;

public class MainWindowViewModel
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public CustomCommand DeletePersonCommand { get; set; } = new();

	/// <summary>
	/// Hier kann auch ein Konstruktor definiert werden, welcher am Start der Anwendung ausgeführt wird
	/// </summary>
    public MainWindowViewModel()
	{
		DeletePersonCommand.ExecuteMethod = DeletePerson;

		string json = File.ReadAllText("Personen.json");
		Person[] personen = JsonSerializer.Deserialize<Person[]>(json);
		foreach (Person p in personen)
			Personen.Add(p);
	}

	/// <summary>
	/// Diese Methode wird an jeden Button angehängt (per Command)
	/// 
	/// Über den Parameter o wird die Person mitgegeben, welche gelöscht werden soll (per Binding)
	/// </summary>
	public void DeletePerson(object o)
	{
		Person p = (Person) o;
		Personen.Remove(p);
	}
}