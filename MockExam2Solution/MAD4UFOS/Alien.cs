using System.Globalization;

public class Alien
{
    #region PREDEFINED CODE, DO NOT MODIFY
    const string NAME_DEFAULT = "Unidentified", DATE_DEFAULT = "Not Provided", LOCATION_DEFAULT = "N/A";
    const string COCKROACH = "Cockroach", CRICKET = "Cricket", OCTO = "Octo";

    public const int LEFT_SPACER = 10, RIGHT_SPACER = -10;

    public static readonly string[] species = { COCKROACH, CRICKET, OCTO };

    private static readonly string[] dateFormats = { "M/d/yyyy", "MM/dd/yyyy" };
    #endregion

    #region STUDENT CODE HERE
    //  Create Private Fields Here
    private string name;
    private string date;
    private string location;
    //  Create Public Properties Here
    public string Name
    {
        get{return name;}
        set
        {
            
            if(string.IsNullOrEmpty(value))
                value = NAME_DEFAULT;

            name = value;
        }
    }
    public string Date
    {
        get{return date;}
        set
        {
            if(!DateIsValid(value))
                value = DATE_DEFAULT;
            date = value;
        }
    }
    public string Location
    {
        get{return location;}
        set
        {
            if(string.IsNullOrEmpty(value))
                value = LOCATION_DEFAULT;
            location=value;
        }
    }

    //  Create Default Constructor Here
    public Alien()
    {
        Name = NAME_DEFAULT;
        Date = DATE_DEFAULT;
        Location = LOCATION_DEFAULT;
    }

    //  Create Parametarized Constructor Here
    public Alien(string name, string date, string location)
    {
        Name = name;
        Date = date;
        Location = location;

    }

    /// <summary>
    /// The ToString to override and customize how to output Alien information
    /// 
    /// Be sure to use LEFT_SPACER and RIGHT_SPACER justification for string formatting to match the output header in 
    /// Program.cs DisplaySightingsHeader() method
    /// </summary>
    /// <returns>Returns the formatted string</returns>
    public override string ToString()
    {
        return string.Format($"{Name, Alien.RIGHT_SPACER} {Date, Alien.LEFT_SPACER} {Location, Alien.RIGHT_SPACER}");
    }
    #endregion

    #region PREDEFINED CODE, DO NOT MODIFY
    /// <summary>
    /// This method validates that an Alien species is valid against existing species in the species array
    /// </summary>
    /// <param name="species">The species string to search</param>
    /// <returns>A bool of true if the species is valid, false otherwise</returns>
    public static bool HaveSpecies(string species)
    {
        //  Convert the string species to upper on the first letter only
        if(!string.IsNullOrEmpty(species))
        {
            char splitBy = ' ';
            string joinBy = " ";

            string[] values = species.Split(splitBy);

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].ToLower();
                values[i] = char.ToUpper(values[i][0]) + values[i].Substring(1);
            }

            species = String.Join(joinBy, values);
        }

        //  Perform the search
        return Array.IndexOf(Alien.species, species) >= 0;
    }

    /// <summary>
    /// This method accepts a string representation of a date and validates whether it is correct or not against the accepted date formats in the string array dateFormats
    /// </summary>
    /// <param name="date">The Date string representation</param>
    /// <returns>Returns bool if validation is successful, false otherwise</returns>
    public static bool DateIsValid(string date)
    {
        return DateTime.TryParseExact(
            date, 
            dateFormats, 
            new CultureInfo("en-US"), 
            DateTimeStyles.None, 
            out DateTime _
        );
    }
    #endregion
}