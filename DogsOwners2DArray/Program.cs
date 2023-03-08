const int ROWS = 50;
const int COLS = 3;

//  This is how you declare and initialize a 2D array
string[,] dogsOwners = new string[ROWS, COLS];

//  This is how you initialize an array with values
dogsOwners[0, 0] = "Floffy";
dogsOwners[0, 1] = "Michael";
dogsOwners[0, 2] = "Mike's Sister";

dogsOwners[1, 0] = "Chewy";
dogsOwners[1, 1] = "Eric";
dogsOwners[1, 2] = "Eric's Sister";

//  This is how you get the counts for rows
// Console.WriteLine($"Row Counts: {dogsOwners.GetLength(0)}");

//  This is how you get the counts for columns
// Console.WriteLine($"Columns Counts: {dogsOwners.GetLength(1)}");

string[] menu = {"Add Dogs and Owners", "Show Dogs and Owners", "Remove a Dog and Owners", "Exit"};
bool continueMenu = true;

while(continueMenu)
{
    switch(ShowMenu())
    {
        case "1":
            AddDogAndOwners();
            break;
        case "2":
            ShowDogsAndOwners();
            break;
        case "3":
            RemoveADogAndOwners();
            break;
        case "4":
            continueMenu = false;
            break;

        default:
            Console.WriteLine($"Invalid Menu Option. Please choose between 1 and {menu.Length}");
            break;
    }

    Console.WriteLine();
}

Console.WriteLine("Thank you for using the Dog and Owners Registration");

string ShowMenu()
{
    for(int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {menu[i]}");
    }

    Console.Write($"Enter an Option Between 1 and {menu.Length}: ");

    return Console.ReadLine();
}

void AddDogAndOwners()
{
    string dogName = string.Empty;

    while(string.IsNullOrEmpty(dogName))
    {
        Console.Write($"Enter the dog's name: ");
        dogName = Console.ReadLine();

        if(string.IsNullOrEmpty(dogName))
            Console.WriteLine("Invalid Dog's Name");
    }

    //  We need to add the dog to the 2D array where the row is empty
    int rowWhereDogIsInserted = 0;
    for(int row = 0; row < dogsOwners.GetLength(0); row++)
    {
        if(string.IsNullOrEmpty(dogsOwners[row,0]))   
        {
            dogsOwners[row,0] = dogName;

            //  We need the row to insert the owners in the correct row for the dog
            rowWhereDogIsInserted = row;
            break;
        }
    }

    //  Now we add the owners
    for(int col = 1; col < dogsOwners.GetLength(1); col++)
    {
        while(true)
        {
            Console.Write($"Enter Owner #{col}'s Name: ");
            string ownerName = Console.ReadLine();

            if(!string.IsNullOrEmpty(ownerName))
            {
                dogsOwners[rowWhereDogIsInserted, col] = ownerName;   
                break;
            }
            else
                Console.WriteLine("Invalid Dog Name");
        }
    }
}

void RemoveADogAndOwners()
{
    Console.Write("Enter the dog's name to remove: ");
    string dogName = Console.ReadLine();
    bool removed = false;
    
    for(int row = 0; row < dogsOwners.GetLength(0); row++)
    {
        // Console.WriteLine(dogsOwners[row, 0]);

        //  Alternatively, you can do things like these:
        // if(dogsOwners[row, 0].Equals(dogName, StringComparison.CurrentCultureIgnoreCase)) { }

        //  This check is important because we have null values in the array
        if(!string.IsNullOrEmpty(dogsOwners[row,0]) && dogsOwners[row,0].ToLower() == dogName.ToLower())   
        {
            //  Alternatively, you can do things like these:
            //  dogsOwners[row, 0] = string.Empty;
            dogsOwners[row, 0] = "";

            //  Remove the Owners
            for(int col = 0; col < dogsOwners.GetLength(1); col++)
            {
                dogsOwners[row, col] = string.Empty;
            }

            //  This is a flag for when a dog is removed, so we can show a message
            removed = true;
        }
    }

    if(removed)
        Console.WriteLine($"{dogName} was removed");
    else
        Console.WriteLine($"{dogName} was not found");
}

void ShowDogsAndOwners()
{
    for (int row = 0; row < dogsOwners.GetLength(0); row++)
    {
        if(!string.IsNullOrEmpty(dogsOwners[row, 0]))
        {
            for (int col = 0; col < dogsOwners.GetLength(1); col++)
            {
                if (col == 0 && !string.IsNullOrEmpty(dogsOwners[row, col]))
                {
                    Console.WriteLine($"The dog's name is {dogsOwners[row, col]}, and its owners are: ");
                    continue;
                }

                if (!string.IsNullOrEmpty(dogsOwners[row, col]))
                    Console.WriteLine($"Dog Owner #{col}: {dogsOwners[row, col]}");
            }

            Console.WriteLine();
        }
    }
}