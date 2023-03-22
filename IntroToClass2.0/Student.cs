public class Student
{
    private string name;
    private double gpa;
    private string major;

    //Setting up a default constructor
    public Student()
    {
        name = "N/A";
        gpa = 0.0;
        major = "N/A";
    }


    /**
    * This is a parameterize constructor that take parameters and assign them to the
    * class fields
    */
    public Student(string studentName, string studentMajor, double studentGPA)
    {
        name = studentName;
        major = studentMajor;
        gpa = studentGPA;
    }

    // //setter
    public void SetName(string studentName)
    {
        if(string.IsNullOrEmpty(studentName))
            name = "N/A";
        else
            name = studentName;
    }

    //accessor
    public string GetName()
    {
        return name;
    }

    public string GetMajor()
    {
        return major;
    }

    public double GetGPA()
    {
        return gpa;
    }

    public void ShowRecord()
    {
        Console.WriteLine($"Name:{name} GPA:{gpa} Major:{major}");
    }
}