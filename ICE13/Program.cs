const int SIZE = 10000;
string[] names = new string[SIZE];
double[] prices = new double[SIZE];
int[] quantities = new int[SIZE];

int index = 0;

string[] menus = {
    "Add Inventory", 
    "View Inventory", 
    "Calculate Inventory Value",
    "Search Inventory By Name",
    "Exit"
};

bool repeat = true;
while(repeat)
{
    //show the menus
    for(int i = 0; i < menus.Length; i++){
        Console.WriteLine($"{i+1}. {menus[i]}");
    }

    //prompt the user for a selection from the menu
    Console.Write("Selection:");
    string choice = Console.ReadLine();

    //perform the operation base on each choice
    switch(choice)
    {
        case "1":
            int quantity;
            double cost;
            string name;
            while(true)
            {
                Console.WriteLine("Enter the item's data");
                Console.WriteLine("Format:item,price,quantity");
                Console.Write("data:");

                string[] data = Console.ReadLine().Split(",");
                if(data.Length < 3){
                    Console.WriteLine("Invalid data");
                    continue;
                }

                name = data[0];

                if(string.IsNullOrEmpty(name)){
                    Console.WriteLine("Name cannot be empty!");
                    continue;
                }

                if(!double.TryParse(data[1], out cost)){
                    Console.WriteLine("Price must be double!");
                    continue;
                }

                if(!int.TryParse(data[2], out quantity)){
                    Console.WriteLine("quantity must be int!");
                    continue;
                }

                //all is good, we will exit the loop
                break;
            }//end of while validating the inputs

            names[index] = name;
            prices[index] = cost;
            quantities[index] = quantity;
            index++;
            Console.WriteLine("The new inventory was successful added");
            break;
        case "2":
            ShowInventoryStuff("Item", "Quantity", "Cost");
            for(int i = 0; i < index; i++)
            {
               ShowInventoryStuff(names[i], quantities[i].ToString(), prices[i].ToString());
            }
            break;
        case "3":
            double total = 0;
            for(int i = 0; i< index; i++)
            {
                total+=quantities[i] * prices[i];
                //total= total + (quantities[i] * prices[i]);
            }

            Console.WriteLine($"Total inventory value:{total:C}");
            break;
        case "4":
            bool found = false;
            string search;
            while(true)
            {
                Console.Write("Search:");
                search = Console.ReadLine();

                if(string.IsNullOrEmpty(search))
                {
                    Console.WriteLine("Search cannot be empty");
                    continue;
                }

                break;
            }
            for(int i = 0; i < index; i++)
            {
                // if(names[i].IndexOf(search)!=-1)
                // {
                //      found = true;
                //     Console.WriteLine("{0,-15} {1,3} {2,15}", "Item","Quantities","Cost");
                //     Console.WriteLine("{0,-10} {1,3} {2,10:C}", names[i], quantities[i], prices[i]);
                //     break;
                // }
                if(names[i].ToLower() == search.ToLower()){
                    found = true;
                    ShowInventoryStuff("Item", "Quantity", "Cost");
                    ShowInventoryStuff(names[i], quantities[i].ToString(), prices[i].ToString());
                    //Console.WriteLine("{0,-15} {1,3} {2,15}", "Item","Quantities","Cost");
                    //Console.WriteLine("{0,-10} {1,3} {2,10:C}", names[i], quantities[i], prices[i]);
                    break;
                }
            }

            if(!found)
            {
                Console.WriteLine("No match was found for "+ search);
            }
            break;
        case "5":
            Console.WriteLine("Thank you for using this application. Good bye!");
            //System.Environment.Exit(0);
            repeat = false;
            break;
        default:
            Console.WriteLine("Invalid choice!");
            break;
    }

    
}

void ShowInventoryStuff(string label1, string label2, string label3)
{
     Console.WriteLine("{0,-15} {1,3} {2,15}", label1,label2,label3);
}