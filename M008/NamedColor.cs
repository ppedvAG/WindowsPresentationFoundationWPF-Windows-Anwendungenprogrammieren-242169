using System.Windows.Media;

namespace M008;

/// <summary>
/// Containerklasse, welche dazu dient, Daten ins XAML zu bewegen (u.a. Name)
/// </summary>
public class NamedColor
{
	public Color Color { get; set; }

	public string Name { get; set; }

	public string HexCode => Color.ToString();

	public SolidColorBrush Brush => new SolidColorBrush(Color);

	public NamedColor(Color color, string name)
	{
		Color = color;
		Name = name;
	}
}