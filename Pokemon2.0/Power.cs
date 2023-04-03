public class Power 
{
    private string name;
    public string Name
    {
        get { return name; }
        set { 
            if(!string.IsNullOrEmpty(value))
                name = value; 
            else
                name = "Undefined Power Name";   
        }
    }
    
    private string type;
    public string Type
    {
        get { return type; }
        set { 
            if(!string.IsNullOrEmpty(value))
                type = value;
            else
                type = "Undefined Power Type";
        }
    }

    public Power() 
    {
        Name = null;
        Type = null;
    }

    public Power(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public override string ToString()
    {
        return $"Name: {name} ({type})";
    }
}