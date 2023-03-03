string[] uuids = new string[10000];
string[] majors = new string[10000];
double[] gpas = new double[10000];

//tracker
int index = 0;

void PromptForSelection()
{
    Console.WriteLine("1. Add new student\n2.Check student GPA\n3.Check student Major");
    Console.Write("Selection:");

    return ; // this is optional
}

void CreateNewStudentRecord()
{
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
}


while(true)
{

    PromptForSelection();
    switch(Console.ReadLine())
    {
        case "1":

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