namespace M007;

public class Fahrzeug
{
	public int MaxV {  get; set; }

	public FahrzeugMarke Marke { get; set; }

	public Fahrzeug(int maxV, FahrzeugMarke marke)
	{
		MaxV = maxV;
		Marke = marke;
	}

	/// <summary>
	/// Ändert die Standarddarstellung im Frontend
	/// </summary>
	public override string ToString()
	{
		return $"MaxV: {MaxV}, Marke: {Marke}";
	}
}

public enum FahrzeugMarke { Audi, BMW, VW }