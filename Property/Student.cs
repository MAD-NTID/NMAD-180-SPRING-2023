public class Student
{
    private string name;

    //If you do not need any validation; create only the property and set the rules(get/set)
    //public DateTime Dob{get;set;}

    public Student()
    {
        Name = "N/A";
    }

    public Student(string name)
    {
        Name = name;
    }

    public string Name
    {
        get
        {
            return name;
        }
        set{
            if(String.IsNullOrEmpty(value)){
                name = "N/A";
            } else {
                name = value;
            }
        }
    }
}