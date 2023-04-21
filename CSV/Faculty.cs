public class Faculty
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    private string position;
    public string Position
    {
        get { return position; }
        set { position = value; }
    }
    
    private List<string>courses;
    public List<string> Courses
    {
        get { return courses; }
        set { courses = value; }
    }


    public Faculty(string name, string position, List<string> courses)
    {
        this.Name = name;
        this.Courses = courses;
        this.Position = position;
    }

    public Faculty()
    {
        this.Name = "N/A";
        this.Courses=new List<string>();
        this.Position = "N/A";
    }

    public override string ToString()
    {
        string coursesString = string.Join(";", courses);
        return $"Name:{name},Courses:{coursesString},Position:{position}";
    }
    
}