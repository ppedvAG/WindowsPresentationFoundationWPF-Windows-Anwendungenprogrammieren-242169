using System.Reflection;
using System.Windows.Markup;
using System.Windows.Media;

namespace M008;

public class ColorsExtension : MarkupExtension
{
	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		PropertyInfo[] colorProperties = typeof(Colors).GetProperties(); //Alle Properties aus der Klasse entnehmen
		NamedColor[] colors = new NamedColor[colorProperties.Length]; //Color Array erstellen
		for (int i = 0; i < colorProperties.Length; i++)
		{
			colors[i] = new NamedColor((Color) colorProperties[i].GetValue(null), colorProperties[i].Name); //Aus jedem Property die Farbe dahinter entnehmen
		}
		return colors;
	}
}
