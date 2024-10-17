using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace M013.ViewModel;

/// <summary>
/// Wenn MVVM Toolkit verwendet werden soll, muss das ViewModel den Typ ObservableObject erben
/// </summary>
public partial class MVVMToolkitViewModel : ObservableObject
{
	[ObservableProperty]
	private int zahl = 0;

	/// <summary>
	/// Test soll an den Button gebunden werden
	/// </summary>
	[RelayCommand]
	public void Test(object o)
	{
		Zahl++;
	}
}