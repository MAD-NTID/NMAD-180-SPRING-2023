using Newtonsoft.Json;
const int JUSTIFY = -20;
//GameSales sale = new GameSales("Call of duty", "Xbox", "10/10/2022", 100, 1500);

List<GameSales> sales = new List<GameSales>();
// {
//     new GameSales("COD", "Xbox", "10/10/2022", 1000, 250000.654)
// };


string[] menus = {
    "Create new sales",
    "Remove a record",
    "Show all sale records",
    "Write records to file",
    "Read in Sales from file",
    "Exit"
};

string MenuSelection()
{
    for(int i = 0; i < menus.Length; i++){
        Console.WriteLine($"{i+1}. {menus[i]}");
    }

    Console.Write("Selection:");
    return Console.ReadLine();
}

void AddNewRecord()
{
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("date:");
    string date = Console.ReadLine();
    Console.Write("Platform:");
    string platform = Console.ReadLine();
    Console.Write("Total copies sold:");
    int copies = int.Parse(Console.ReadLine());
    Console.Write("Total Revenue:");
    double revenue = double.Parse(Console.ReadLine());

    GameSales sale = new GameSales(name, platform, date, copies, revenue);
    sales.Add(sale);
    Console.WriteLine("New sale record added");
    return;
}

void RemoveRecord()
{
    Console.Write("Name:");
    string name = Console.ReadLine();
    Console.Write("Platform:");
    string platform = Console.ReadLine();

    bool found = false;
    foreach(GameSales sale in sales)
    {
        if(sale.Name.ToLower() == name.ToLower() && platform.ToLower() == sale.Platform.ToLower())
        {
            sales.Remove(sale);
            found = true;
            Console.WriteLine("Record has been removed!");
            break;//!!! DONT FORGET THIS
        }
    }

    if(!found) {
        Console.WriteLine("No record was found with the given name and platform");
    }
}

void WriteToFile()
{
    string filename = "";
    while(true)
    {
        Console.WriteLine("filename:");
        filename = Console.ReadLine();

        //the name of the file must end with .csv
        if(!filename.EndsWith(".json")){
            Console.WriteLine("the file name must end with .json");
            continue;
        }
        break;
    }

    StreamWriter writer = new StreamWriter(filename);
    string content = JsonConvert.SerializeObject(sales);
    writer.WriteLine(content);
    // foreach(GameSales sale in sales)
    // {
    //     writer.WriteLine($"{sale.Name},{sale.Platform},{sale.Date},{sale.TotalCopiesSold},{sale.TotalRevenue}");
    // }

    Console.WriteLine("The contents was successfully written to the file");
    writer.Close();
    
}

void ReadFromFile()
{
    Console.Write("Filename:");
    string filename = Console.ReadLine();


    if(!File.Exists(filename)) {
        Console.WriteLine($"Not able to located the file {filename}. Returing to main menu....");
        return ;
    }

    StreamReader reader = new StreamReader(filename);
    // //writer.WriteLine($"{sale.Name},{sale.Platform},{sale.Date},{sale.TotalCopiesSold},{sale.TotalRevenue}");

    // while(!reader.EndOfStream){
    //     string line = reader.ReadLine();
    //     if(!string.IsNullOrEmpty(line)) {
    //         string[] data = line.Split(",");
            
    //         GameSales sale = new GameSales(data[0], data[1], data[2], int.Parse(data[3]), double.Parse(data[4]));
    //         sales.Add(sale);
            
    //     }
    // }

    string content = reader.ReadToEnd();
    sales = JsonConvert.DeserializeObject<List<GameSales>>(content);

    Console.WriteLine("The content was successfully loaded to the game sales list!");
}

bool repeat = true;
while(repeat)
{
    switch(MenuSelection())
    {
        case "1":
            AddNewRecord();
        break;
        case "2":
            RemoveRecord();
        break;
        case "3":
            if(sales.Count == 0)
            {
                Console.WriteLine("No records to show");
                return;
            }
            foreach(GameSales record in sales){
                Console.WriteLine($"{"Name", JUSTIFY} {"Platform",JUSTIFY} {"Date", JUSTIFY} {"TotalCopiesSold", JUSTIFY} {"TotalRevenue", JUSTIFY:C}");
                Console.WriteLine(record);
            }
        break;
        case "4":
            WriteToFile();
        break;
        case "5":
            ReadFromFile();
        break;
        case "6":
            Console.WriteLine("Thank you for using our program. Program exiting");
            //Environment.Exit(0);
            repeat = false;
        break;
        default:
            Console.WriteLine($"Invalid selection. Select from 1-{menus.Length}");
            break;
        
    }
}
