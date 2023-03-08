class MethodThreePointO
{
    static void Main(string[] args)
    {
        string[] menuChoices = {"Add Student", "Add Student with Age", "Add Student with Age and Major", "Exit"};

        Console.WriteLine("This program doesn't actually add any students to an array.\n" + 
        "It's simply to show, how you can use overload methods");

        while(true)
        {
            string studentName, major;
            int age;

            switch(ShowMenu(menuChoices))
            {
                case "1":
                    Console.Write("Enter Student's Name:");
                    studentName = Console.ReadLine();

                    AddStudent(studentName);
                    break;

                case "2":
                    Console.Write("Enter Student's Name:");
                    studentName = Console.ReadLine();

                    Console.Write("Enter Student's Age:");
                    age = int.Parse(Console.ReadLine());

                    AddStudent(studentName, age);
                    break;

                case "3":
                    Console.Write("Enter Student's Name:");
                    studentName = Console.ReadLine();

                    Console.Write("Enter Student's Age:");
                    age = int.Parse(Console.ReadLine());

                    Console.Write("Add Major (y/n)? ");
                    string majorACT = Console.ReadLine();

                    if(majorACT.ToLower() == "n")
                        AddStudent(studentName, age);
                    else
                    {
                        Console.Write("What is the student's major? ");
                        major = Console.ReadLine();
                        AddStudent(studentName, age, major);
                    }
                    
                    break;

                case "4":
                    Console.WriteLine("Bye bye now");
                    Environment.Exit(0);

                    break;

                default: 
                    Console.WriteLine("Invalid Choice");
                    break;
            }

            Console.WriteLine();
        }

        //  Alternatively
        // string choice = ShowMenu(menuChoices);

        // switch(choice)
        // {

        // }
    }

    static string ShowMenu(string[] menuChoices) 
    {
        for(int i = 0; i < menuChoices.Length; i++)
        {
            Console.WriteLine($"{i + 1}: {menuChoices[i]}");
        }

        Console.Write("Select an Option: ");

        return Console.ReadLine();
    }

    static void AddStudent(string name)
    {
        Console.WriteLine($"Student Name is: {name}");
    }

    static void AddStudent(string name, int age, string major = "ACT")
    {
        Console.WriteLine($"Student Name is: {name} and their age is {age}. The student's major is {major}.");
    }
}