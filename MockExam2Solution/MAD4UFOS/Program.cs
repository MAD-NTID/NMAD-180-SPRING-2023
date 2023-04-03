#region Predefined Code, DO NOT MODIFY
const string HEADER = "MAD4UFOS Data Collection System";
const string DASHER = "--------";

string[] menu = { 
    "Enter a Sighting", 
    "Display all sightings", 
    "Display sightings filtered by species", 
    "Display Record Count", 
    "Exit" 
};

Alien[] aliens = new Alien[1000];
int index = 0;

//testing, remove or comment out when done
// Alien[] aliens = {
//     new Alien("Osman", "10/10/2023", "Rochester"),
//     new Alien("Erik", "10/10/2021", "Maine")
// };

// int index = aliens.Length;
#endregion


Console.Title = HEADER;

#region STUDENT CODE HERE
//small test
// Alien alien = new Alien();
// Console.WriteLine(alien.ToString());
// alien = new Alien("Osman", "04/03/2023", "LBJ-2355");
// Console.WriteLine(alien.ToString());

/*
 * Uncomment this method when you are ready to code for it
 * Create the method in the Region STUDENT METHOD CODES HERE
 * */
DisplayHeader();

/*
 * This while loop is controlled by the continueProgram bool variable
 * For exiting this loop, set the continueProgram variable to false as needed
 * 
 * You may optional use Environment.Exit(0)
 * */
bool continueProgram = true;
while (continueProgram)
{
    /*
     * Uncomment this method when you are ready to code for it
     * Create the method in the Region STUDENT METHOD CODES HERE
     * */
    DisplayMenu();

    switch (GetMenuSelection())
    {
        case 1:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            EnterASighting();

            break;
        case 2:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            DisplayAllSightings();

            break;
        case 3:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            FilterBySpecies();

            break;
        case 4:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            DisplayRecordCount();

            break;
        case 5:
            /*
             * Uncomment this method when you are ready to code for it
             * Create the method in the Region STUDENT METHOD CODES HERE
             * */
            continueProgram = !Exit();

            break;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==> Invalid choice");
            Console.ResetColor();

            break;
    }
}
#endregion

#region STUDENT METHOD CODES HERE
//  Code for DisplayHeader() here
void DisplayHeader()
{
    Console.WriteLine(HEADER);
    Console.WriteLine(DateTime.Now.ToString());
}
//  Code for DisplayMenu() here
void DisplayMenu()
{
    Console.WriteLine("Main Menu\n========");
    for(int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i+1}. {menu[i]}");
    }

    Console.Write($"Enter your selection (1-{menu.Length}):");
}

//  Code for EnterASighting() here
void EnterASighting()
{
    //Create code that will prompt the user to enter the following information
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Date:");
    string date = Console.ReadLine();
    Console.Write("Location:");
    string location = Console.ReadLine();

    //Create an Alien object based on the information provided
    Alien alien = new Alien(name, date, location);
    aliens[index] = alien;
    index++;




}

//  Code for DisplayAllSightings() here
void DisplayAllSightings()
{
    DisplaySightingsHeader();
    foreach(Alien alien in aliens)
    {
        if(alien is not null)
            Console.WriteLine(alien.ToString());
    }

    Console.WriteLine($"==>{index} records displayed");
}

//  Code for FilterBySpecies() here
void FilterBySpecies()
{
    Console.Write("Name:");
    string name = Console.ReadLine();

    DisplaySightingsHeader();
    int count = 0;
    foreach(Alien alien in aliens)
    {
        if(alien is not null && alien.Name == name)
        {
            Console.WriteLine(alien.ToString());
            count++;
        }
            
    }

    Console.WriteLine($"==>{count} records displayed");
}

//  Code for DisplayRecordCount() here
void DisplayRecordCount()
{
    Console.WriteLine($"There are {index} aliens sighted");
}

//  Code for Exit() here
bool Exit()
{
    while(true)
    {
        Console.Write("Are you sure: (Y/N)");
        string response = Console.ReadLine().ToUpper();
        if(response == "Y")
        {
            Console.WriteLine($"Thank you for using {HEADER}. Goodbye!!");
            return true;
        }
            
        else if(response == "N")
            return false;
        
        Console.WriteLine("Invalid option! Please select Y/N");
    }
}
#endregion

#region PREDEFINED CODE, DO NOT MODIFY
/// <summary>
/// This method will validate that the menu choice is valid.
/// </summary>
/// <returns>Returns the int value for the menu selection made</returns>
int GetMenuSelection()
{
    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= menu.Length)
        return choice;

    return -1;
}



/// <summary>
/// This method can be used when you want to display a header for all the Alien sightings before listing them
/// </summary>
static void DisplaySightingsHeader()
{
    Console.WriteLine($"{"Species", Alien.RIGHT_SPACER} {"Date", Alien.LEFT_SPACER} {"Location", Alien.RIGHT_SPACER}");
    Console.WriteLine($"{DASHER, Alien.RIGHT_SPACER} {DASHER, Alien.LEFT_SPACER} {DASHER, Alien.RIGHT_SPACER}");
}
#endregion