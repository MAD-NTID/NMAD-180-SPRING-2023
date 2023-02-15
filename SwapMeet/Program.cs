//setting up constants
const string BUSINESS_NAME = "Disks4Cheap";
const double DISK_PRICE = 25.75;

Console.WriteLine(BUSINESS_NAME);

//ask for the inventory
Console.Write("Enter current inventory:");

//validate that the inventory is a number and positive
if(!int.TryParse(Console.ReadLine(), out int inventory) || inventory < 0){
    Console.WriteLine("Please enter a positive number!");
    System.Environment.Exit(0);
}

//show the user the menu
Console.WriteLine("Menu\n========");
Console.WriteLine("1. Display current inventory value");
Console.WriteLine($"2. Buy disks from {BUSINESS_NAME}");
Console.WriteLine($"3. Sell disks to {BUSINESS_NAME}");
Console.WriteLine("4. Exit");

//prompt the user what they want to do from the menu
Console.Write("Selection:");
switch(Console.ReadLine())
{
    case "1":
        double totalCost = inventory * DISK_PRICE;
        Console.WriteLine($"Total inventory:{inventory} and Total cost:{totalCost:C}");
        break;
    case "2":
        Console.Write("How many disks do you want to sell:");
        int sold = int.Parse(Console.ReadLine());
        if(sold > inventory){
            Console.WriteLine("disks total must not be more than the inventory disks!");
        } else {
            inventory-=sold;
            totalCost = inventory * DISK_PRICE;
            Console.WriteLine($"Total inventory:{inventory} and Total cost:{totalCost:C}");
        }
        break;
    case "3":
        
        Console.Write("How many disks are you buying:");
        int buying = int.Parse(Console.ReadLine());
        if( buying < 0) {
            Console.WriteLine("Please enter a positive number!");
        } else {
            inventory+=buying;
            totalCost = inventory * DISK_PRICE;
            Console.WriteLine($"Total inventory:{inventory} and Total cost:{totalCost:C}");
        }
        break;
    case "4":
        Console.WriteLine("Thank you for visiting us");
        break;

    default:
        Console.WriteLine("Invalid selection!");
        break;
}