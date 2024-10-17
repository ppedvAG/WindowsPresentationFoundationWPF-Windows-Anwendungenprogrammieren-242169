using System.Windows;

namespace M012;

public partial class MainWindow : Window
{
	/// <summary>
	/// Commands müssen als Properties angelegt werden, und per Binding in der GUI angebunden werden
	/// </summary>
	public ExitCommand ExitCmd { get; set; } = new ExitCommand();

	public CustomCommand CustomExitCmd { get; set; } = new CustomCommand();

	public MainWindow()
	{
		//Hier wird dem Command sein Methodenzeiger gegeben
		CustomExitCmd.ExecuteMethod = Exit;

		InitializeComponent();
	}

	/// <summary>
	/// Normale Methode, welche dem Command als Methodenzeiger mitgegeben wird
	/// </summary>
	public void Exit(object o)
	{
		Environment.Exit(0);
	}
}