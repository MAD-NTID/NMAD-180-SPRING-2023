// int count = 1;

// while(count < 10)
// {
//     Console.WriteLine($"While loop::: The count is: {count}");
//     count++;
// }

// for(int i  = 0; i< 10; i++){
//     Console.WriteLine($"for loop::: The count is: {i}");
// }

string[] students = new string[10];

// for(int index = 0; index < 5; index++){
//     Console.Write("Enter student name:");
//     string name = Console.ReadLine();

//     students[index] = name;
// }

// for(int i = 0; i< 5; i++) {
//     Console.WriteLine($"student {i}: {students[i]}");
// // }

// int index = 0;
// while(true)
// {
//     Console.WriteLine("Press q to quit");
//     Console.Write("Enter the name of the student:");

//     string name = Console.ReadLine();

//     if(name == "q")
//         break;
    
//     students[index] = name;
//     index++;
// }

// for(int i = 0; i< 5; i++) {
//     Console.WriteLine($"student {i}: {students[i]}");
// }

int index = 0;
while(true)
{
    Console.WriteLine("1. Add a new student");
    Console.WriteLine("2. Search for a student");
    Console.WriteLine("3. Remove a student");
    Console.WriteLine("4. Exit");

    Console.Write("Selection:");
    string choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            Console.Write("Enter student's name:");
            string name = Console.ReadLine();
            students[index] = name;
            index++;
            Console.WriteLine("new student added");
        break;
        case "2":
            Console.Write("Name of the student to search for:");
            name = Console.ReadLine();

            bool found = false;
            for(int i = 0; i< students.Length; i++){
                string student = students[i];

                if(student == name){
                    Console.WriteLine($"{student} found!!");
                    found = true;
                    break;//we found a match.. no need to continue with the rest of the search
                } 
            }

            if(found==false){
                Console.WriteLine($"{name} not found!!");
            }
        break;
        case "3":
        break;
        case "4":
            Console.WriteLine("Thank you for playing along");
            System.Environment.Exit(0);
            
        break;
        default:
            Console.WriteLine("Invalid choice. Please select 1-4");
            break;
    }
}