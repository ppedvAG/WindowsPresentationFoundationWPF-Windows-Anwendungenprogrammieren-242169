using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace M000.Model;

/// <summary>
/// Schritt 1
/// 
/// Add -> Class -> class zu enum ändern
/// </summary>
public class Person : INotifyPropertyChanged
{
    private string vorname;
    private string nachname;
    private DateTime geburtsdatum;
    private bool verheiratet;
    private Color lieblingsfarbe;
    private Geschlecht geschlecht;
	private int anzKinder;

    public string Vorname
    {
        get => vorname;
        set
        {
            vorname = value;
            Notify();
        }
    }

    public string Nachname
    {
        get => nachname;
        set
        {
            nachname = value;
            Notify();
        }
    }

    public DateTime Geburtsdatum
    {
        get => geburtsdatum;
        set
        {
            geburtsdatum = value;
            Notify();
        }
    }

    public bool Verheiratet
    {
        get => verheiratet;
        set
        {
            verheiratet = value;
            Notify();
        }
    }

    public Color Lieblingsfarbe
    {
        get => lieblingsfarbe;
        set
        {
            lieblingsfarbe = value;
            Notify();
        }
    }

    public Geschlecht Geschlecht
    {
        get => geschlecht;
        set
        {
            geschlecht = value;
            Notify();
        }
    }

	public int AnzKinder
	{
		get => anzKinder;
		set
		{
			anzKinder = value;
			Notify();
		}
	}

	//Schritt 2

	public event PropertyChangedEventHandler? PropertyChanged;

    public void Notify([CallerMemberName] string propName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
}