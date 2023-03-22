//default constructor example
// Student justin = new Student();
// justin.ShowRecord();

//parametrized constructor example
// Student justin = new Student("Justin", "IT", 3.5);
// justin.ShowRecord();

Student justin = new Student();
justin.ShowRecord();

justin =  new Student("Justin", "IT", 3.0);

justin.SetName("");
Console.WriteLine(justin.GetName());
justin.SetName("Justin");
Console.WriteLine(justin.GetName());
Console.WriteLine(justin.GetGPA());
Console.WriteLine(justin.GetMajor());



// int x = 5;
// Console.WriteLine(x);

// int x = 7;
// Console.WriteLine(x);
