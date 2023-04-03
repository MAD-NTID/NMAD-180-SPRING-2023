public class Pokemon
{
    public const int DEFAULT_NUMBER_OF_POWERS = 3;

    private string name;
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
                value = "N/A";

            name = value;
        }
    }

    private string color;
    public string Color
    {
        get { return color; }
        set
        {
            if (string.IsNullOrEmpty(value))
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
            if (value < 1)
                value = 1;

            level = value;
        }
    }

    private string owner;
    public string Owner
    {
        get { return owner; }
        set
        {
            if (string.IsNullOrEmpty(value))
                value = "N/A";
            owner = value;
        }
    }

    private Power[] powers;
    public Power[] Powers
    {
        get { return powers; }
        set
        {
            powers = value;

            if (powers == null)
                powers = new Power[DEFAULT_NUMBER_OF_POWERS];
            else
                Powers = powers;
        }
    }

    //default constructor
    public Pokemon()
    {
        Name = "N/A";
        Level = 1;
        Owner = "N/A";
        Color = "N/A";
        Powers = null;
    }

    public Pokemon(string name, string color, string owner, int level, Power[] powers = null)
    {
        Name = name;
        Color = color;
        Owner = owner;
        Level = level;
        Powers = powers;
    }

    public bool HasSpaceForPower()
    {
        bool hasSpace = false;

        for(int i = 0; i < powers.Length; i++)
            if(powers[i] == null)
            {
                hasSpace = true;
                break;
            }

        return hasSpace;
    }

    public void AddPower(Power power)
    {
        for(int i = 0; i < powers.Length; i++)
        {
            //  Find an empty space in the Powers array
            if(powers[i] is null)   //  alternatively powers[i] == null
            {
                powers[i] = power;
                break;
            }
        }
    }

    public override string ToString()
    {
        string powerstring = string.Empty;
        foreach(Power power in Powers)
            powerstring += $"{power}, ";

        return $"Name:{name}\nLevel:{level}\nColor:{color}\nOwner:{owner}\nPowers:{powerstring}";
    }
}