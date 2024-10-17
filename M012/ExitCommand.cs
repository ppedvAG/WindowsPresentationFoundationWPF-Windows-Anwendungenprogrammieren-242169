using System.Windows.Input;

namespace M012;

/// <summary>
/// Command, welches das Programm beendet
/// </summary>
public class ExitCommand : ICommand
{
	/// <summary>
	/// Wird von der UI verwendet -> Kann von uns ignoriert werden
	/// </summary>
	public event EventHandler? CanExecuteChanged;

	/// <summary>
	/// Wenn das Command ausgeführt wird, wird die Execute Methode ausgeführt
	/// 
	/// Beispiel: Click auf den Button
	/// </summary>
	public void Execute(object? parameter)
	{
		Environment.Exit(0);
	}

	/// <summary>
	/// Gibt bekannt, ob das Command jetzt ausgeführt werden könnte
	/// 
	/// Beispiel: Button
	/// - Wenn CanExecute false zurückgibt, wird der Button deaktiviert (IsEnabled=False)
	/// </summary>
	public bool CanExecute(object? parameter) => true;
}