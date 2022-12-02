using System;

public class Lugar
{
	public static int MIN_ID = 1, MAX_ID = 126;
	public int id { get; set; }
	public string name { get; set; }
	public string type { get; set; }
	public string dimension { get; set; }
	public string[] residents { get; set; }
	public string created { get; set; }

	public Lugar()
	{

	}
}
