Student osman = new Student();
//osman.Name = "Osman";

Console.WriteLine(osman.Name);

string erikName = "";
Student erik = new Student(erikName);

Console.WriteLine(erik.Name);

Student justin = new Student(null);
Console.WriteLine(justin.Name);