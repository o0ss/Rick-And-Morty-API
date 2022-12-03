using System;

public class Episodio
{
	public Episodio()
	{
		
	}
	public static int MIN_ID = 1, MAX_ID = 51;

	public int id { get; set; }
	public string name { get; set; }
	public string air_date { get; set; }
	public string episode { get; set; }
	public string[] characters { get; set; }
}