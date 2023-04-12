public class Pokemon
{
    private string name;
    public string Name
    {
        get { return name; }
        set 
        { 
            name = string.IsNullOrEmpty(value) ? "N/A" : value;
             
        }
    }

    private string  color;
    public string  Color
    {
        get { return color; }
        set 
        { 
            if(string.IsNullOrEmpty(value))
                value = "N/A";
            color = value; 
        }
    }

    private int level;
    public int Level
    {
        get { return level; }
        set 
        { 
            if(value < 1)
                value = 1;

            level = value; 
        }
    }



    private string  owner;
    public string  Owner
    {
        get { return owner; }
        set 
        { 
            if(string.IsNullOrEmpty(value))
                value = "N/A";
            owner = value; 
        }
    }

    //default constructor
    public Pokemon()
    {
        Name = "N/A";
        Level = 1;
        Owner = "N/A";
        Color = "N/A";
    }

    public Pokemon(string name, string color, string owner, int level)
    {
        Name = name;
        Color = color;
        Owner = owner;
        Level = level;
    }

    public override string ToString()
    {
        return $"Name:{name} Level:{level} Color:{color} Owner:{owner}";
    }
    


    
    
    
}