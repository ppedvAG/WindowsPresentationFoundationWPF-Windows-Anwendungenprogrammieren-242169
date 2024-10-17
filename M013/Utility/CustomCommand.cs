using System.Windows.Input;

namespace M013.Utility;

/// <summary>
/// CustomCommand
/// 
/// Klasse, welche Code über eine Variable speichert, und den Code innerhalb dieser Variable bei der Execute Methode ausführt
/// 
/// Vorteil: Nicht mehr eine Klasse pro Button in der Anwendung notwendig, sondern einer generische Klasse, welche alle Buttons benutzen können
/// </summary>
public class CustomCommand : ICommand
{
	public event EventHandler? CanExecuteChanged;

	/// <summary>
	/// Methodenzeiger, welcher auf einer beliebige Methode zeigt
	/// 
	/// In der Execute Methode wird dieser Methodenzeiger ausgeführt (die Methode hinter dem Methodenzeiger)
	/// 
	/// Action: Methodenzeiger, welcher void zurückgibt
	/// <object>: Definiert, das dieser Methodenzeiger einen Parameter haben muss (vom Typ object)
	/// </summary>
	public Action<object> ExecuteMethod;

	public Func<object, bool> CanExecuteMethod;

    public void Execute(object? parameter)
	{
		//Der Parameter, welcher aus der GUI kommt, wird hier an den Methodenzeiger weitergegeben
		ExecuteMethod.Invoke(parameter); //Invoke: Führe die Methode aus
	}

	public bool CanExecute(object? parameter)
	{
		if (CanExecuteMethod == null)
			return true;

		return CanExecuteMethod.Invoke(parameter);
	}
}