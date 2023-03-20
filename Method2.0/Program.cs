string[] uuids = new string[10000];
string[] majors = new string[10000];
double[] gpas = new double[10000];

//tracker
int index = 0;

/**
    This method prompts the user for a selection from the menu
**/
void PromptForSelection()
{
    Console.WriteLine("1. Add new student\n2.Check student GPA\n3.Check student Major");
    Console.Write("Selection:");

    return ; // this is optional
}

/**
    This method prompts the user for the student record and add them to the array.
    After the record has been added, the next available location in the index is incremented
**/
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


/**
 This method prompts the user for the uuid. If the uuid is null or empty, the user is shown an error 
 reprompt for the uuid. Otherwise the method returns the uuid.
**/
string PromptForUUID()
{
    string uuid;
    while(true)
    {
        Console.Write("uuid:");
        uuid = Console.ReadLine();

        if(string.IsNullOrEmpty(uuid)){
            Console.WriteLine("uuid cannot be empty!");
            continue;
        }

        return uuid;
    }
}

void SearchForStudentRecord(string uuid)
{
    for(int i = 0; i< index; i++)
    {
        if(uuids[i] == uuid){
            Console.WriteLine($"{uuid}'s GPA is: {gpas[i]}");
            break;
        }
    }
}


while(true)
{

    PromptForSelection();
    switch(Console.ReadLine())
    {
        case "1":
            CreateNewStudentRecord();
            break;
        case "2":

            string uuid = PromptForUUID();
            SearchForStudentRecord(uuid);
            break;
        default:
            Console.WriteLine("Invalid selection");
            break;
    }
}