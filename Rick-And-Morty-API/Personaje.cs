public class Personaje
{
    public int id { get; set; }
    public string name { get; set; }
    public string status { get; set; }
    public string species { get; set; }
    public string type { get; set; }
    public string gender { get; set; }
    public string image { get; set; }  
    public string created { get; set; }
    public const int MAX_ID = 826;
    public const int MIN_ID = 1;

    override public string ToString()
    {
        string str = string.Format(
            "{0,10}: {1}\n" +
            "{2,10}: {3}\n" +
            "{4,10}: {5}\n" +
            "{6,10}: {7}\n\n",
            "id", id,
            "name", name,
            "species", species,
            "type", type
            );

        return str;
    }
}