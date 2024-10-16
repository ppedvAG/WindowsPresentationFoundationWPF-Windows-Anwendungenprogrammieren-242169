using System.Windows.Markup;

namespace M008;

public class EnumExtension : MarkupExtension
{
	/// <summary>
	/// Wenn in einer MarkupExtension ein Property definiert wird, darf dieses im XAML gesetzt werden
	/// </summary>
	public Type EnumType { get; set; }

	/// <summary>
	/// Wenn die GUI den Wert von dem Binding anfordert, wird ProvideValue ausgeführt
	/// 
	/// Wenn das Programm gestartet wird/die ComboBox geöffnet wird, wird der Wert der Methode entnommen, und in die GUI eingebaut
	/// </summary>
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		if (!EnumType.IsEnum)
			throw new ArgumentException("EnumType ist kein Enum Typ");

		return Enum.GetValues(EnumType);
	}
}