using SimpleJSON;


public class Parser
{
    public FortumJson[] Json { get; set; }
}

public class FortumJson
{
    public int location { get; set; }
    public string city { get; set; }
    public int zipcode { get; set; }
    public int amountofinhabitants { get; set; }
    public int buildingyear { get; set; }
    public int cubicmeters { get; set; }
    public int electricityheatingsurface { get; set; }
    public int squaremeters { get; set; }
    public string buildingtype_id { get; set; }
    public string primaryheatingtype_id { get; set; }
    public string secondaryheatingtype_id { get; set; }
}
