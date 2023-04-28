public class GameSales
{
    private const string DEFAULT_NAME = "Name not provided";
    private const string DEFAULT_PLATFORM = "Platform not provided";
    private const string DEFAULT_DATE = "Date not provided";

    private const int JUSTIFY = -20;

    private string name;
    private string date;
    private string platform;
    private int totalCopiesSold;
    private double totalRevenue;

    public string Name 
    { 
        get{
            return name;
        }
        set{
            if(string.IsNullOrEmpty(value))
                value = DEFAULT_NAME;
            name = value;
        }
    }
    public string Date 
    { 
        get
        {
            return date;
        } 
        set
        {
            if(!DateTime.TryParse(value, out DateTime d))
                value = DEFAULT_DATE;
            date = value;
        } 
    }
    public string  Platform 
    { 
        get{
            return platform;
        }
        set{
            if(string.IsNullOrEmpty(value))
                value = DEFAULT_PLATFORM;
            platform = value;
        }
    }
    public int TotalCopiesSold 
    { 
        get{
            return totalCopiesSold;
        }
        set
        {
            if(value >=0)
                totalCopiesSold = value;
        } 
    }
    public double TotalRevenue 
    { 
        get
        {
            return totalRevenue;
        }
        set{
            if(value>=0)
                totalRevenue = value;
        }
    }

    public GameSales(string name, string platform, string date, int totalCopiesSold, double totalRevenue)
    {
        Name = name;
        Platform = platform;
        Date = date;
        TotalCopiesSold = totalCopiesSold;
        TotalRevenue = totalRevenue;

    }

    public override string ToString()
    {
        return $"{Name, JUSTIFY} {Platform,JUSTIFY} {Date, JUSTIFY} {TotalCopiesSold, JUSTIFY} {TotalRevenue, JUSTIFY:C}";

    }
}