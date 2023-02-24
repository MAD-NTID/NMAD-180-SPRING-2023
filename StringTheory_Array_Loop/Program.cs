// string[] names = new string[4];


// for(int i = 1; i<= 10; i++){
//     //skip if we have an even number
//     if(i%2==0)
//         continue;
    
//     Console.WriteLine(i);
// }

// string name = "Kemoy campbel";
// name = "Osman";



// Console.WriteLine(name[0]);

// while(true)
// {
//     Console.Write("Type something:");
//     string input = Console.ReadLine();

//     if(input.ToLower() == "q") {
//         Console.WriteLine("We are sad to see you go... :-( * Jordon cry **");
//         break;
//     }

//     Console.WriteLine("You typed: " + input);
// }

//Kemoy;Campbell
// Console.WriteLine("Enter your full name:");
// string input = Console.ReadLine();
// string[] names = input.Split(" ");

// Console.WriteLine($"Your first name is:{names[0]} and your last name is {names[1]}");

// while(true)
// {
//     Console.Write("Do you want to quit: (Y/N)");
//     string input = Console.ReadLine();

//     if(input.ToLower().ToCharArray()[0]=='y'){
//         Console.WriteLine("Bye my friend!");
//         break;
//     }
// }

//strings[] names = new string[4];
//names[0] = "Justing"
//....
string[] names = {"Justin", "Erik", "Eric", "Osman","FooEri"};

//students name starting with Eri only
// for(int i = 0; i < names.Length; i++)
// {
//     string student = names[i];
//     if(student.Substring(0,3)=="Eri"){
//         Console.WriteLine(student);
//     }
// }

//student name containing Eri, could be anywhere
for(int i = 0; i< names.Length; i++)
{
    string student = names[i];
    if(student.IndexOf("Eri")!=-1){
        Console.WriteLine(student);
    }
}

