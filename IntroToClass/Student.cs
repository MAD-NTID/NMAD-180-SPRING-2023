public class Student
{
    public string name;
    public double gpa;
    public string major;


    public void ShowRecord()
    {
        Console.WriteLine($"Name:{name} GPA:{gpa} Major:{major}");
    }
}