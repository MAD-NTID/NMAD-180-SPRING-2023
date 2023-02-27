// // for(int i = 1; i <=100; i++)
// // {
// //     if(i% 2 == 0)
// //         Console.WriteLine(i);
// // }

// string[] words = new string[10000];
// Console.Write("Enter some words:");
// string input = Console.ReadLine();

// string[] inputs = input.Split(" ");

// for(int i = 0; i < inputs.Length; i++)
// {
//     words[i] = inputs[i];
// }

// string reverse = "";
// for(int i = words.Length - 1; i >= 0; i--)
// {
//     if(words[i]== "")
//         continue;
    
//     Console.Write(words[i] + " ");
//     reverse+=words[i] + " ";
// }

// Console.WriteLine(reverse);
// Console.WriteLine();



// int[] numbers = {1,2,3,4,5,6,7};

// foreach(int number in numbers)
// {
//     Console.WriteLine("The current number is: "+ number);
//     break;
// }

string[] uuids = new string[10000];
string[] majors = new string[10000];
double[] gpas = new double[10000];

//tracker
int index = 0;


while(true)
{
    Console.WriteLine("1. Add new student\n2.Check student GPA\n3.Check student Major");
    Console.Write("Selection:");

    switch(Console.ReadLine())
    {
        case "1":
            Console.Write("uuid:");
            string uuid = Console.ReadLine();

            Console.Write("Major:");
            string major = Console.ReadLine();

            Console.Write("GPA:");
            double gpa = double.Parse(Console.ReadLine());

            uuids[index] = uuid;
            majors[index] = major;
            gpas[index] = gpa;
            Console.WriteLine("\nNew student added");
            index++; // move the tracker to the next available location
            break;
        case "2":
            while(true)
            {
                Console.Write("uuid:");
                uuid = Console.ReadLine();

                if(string.IsNullOrEmpty(uuid)){
                    Console.WriteLine("uuid cannot be empty!");
                    continue;
                }

                break;
            }

            for(int i = 0; i< index; i++)
            {
                if(uuids[i] == uuid){
                    Console.WriteLine($"{uuid}'s GPA is: {gpas[i]}");
                    break;
                }
            }
            break;
        default:
            Console.WriteLine("Invalid selection");
            break;
    }
}