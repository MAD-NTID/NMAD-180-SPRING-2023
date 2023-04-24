
using Newtonsoft.Json;

Dictionary<string, Faculty> faculties = new Dictionary<string, Faculty>();


List<string> menus = new List<string>()
{
    "Add Faculty",
    "Show all faculties",
    "Load Faculties From File",
    "Write Faculties to file",
    "Exit"
};

string MenuSelection()
{
    Console.WriteLine("Menu\n=========");
    for(int i = 0; i < menus.Count; i++) {
        Console.WriteLine($"{i+1}. {menus[i]}");
    }

    Console.Write("Selection:");
    return Console.ReadLine();
}

string PromptString(string prompt, string errorMessage)
{
    while(true)
    {
        Console.Write(prompt);
        string response = Console.ReadLine();
        if(string.IsNullOrEmpty(response)) 
        {
            Console.WriteLine(errorMessage);
            continue;
        }

        return response;
    }
}

void PromptForFaculty()
{
    string name = PromptString("Enter the name of the faculty:" , "Faculty name cannot be empty");
    string position =PromptString("Enter the faculty position:", "Position cannot be empty");
    
    List<string> courses = new List<string>();
    while(true)
    {
            string course = PromptString("Enter the name of the course:", "Course name cannot be empty");
            courses.Add(course);

            Console.Write("Do you want to add another course?:");
            string response = Console.ReadLine();
            if(response.ToUpper()[0]=='Y')
                continue;
            break;
    }


    faculties.Add(name, new Faculty(name, position, courses));
    Console.WriteLine("Faculty was successfully added");
}

void WriteToFile()
{
    string filename = PromptString("Enter the name of the file:", "Filename cannot be empty");
    StreamWriter writer = new StreamWriter(filename);

    string record = JsonConvert.SerializeObject(faculties);
    writer.WriteLine(record);
    writer.Close();
    Console.WriteLine("Data has been saved to the file");

    // writer.WriteLine("Name,Position,Courses");
    // foreach(KeyValuePair<string,Faculty> faculty in faculties)
    // {
    //     Faculty fac = faculty.Value;
    //     string fields = $"{fac.Name},{fac.Position},{string.Join(";",fac.Courses)}";
    //     writer.WriteLine(fields);
    // }

    // writer.Close();
    // Console.WriteLine("Data has been saved to the file");
}

void ReadAndLoadDataFromFile(bool prompt)
{
    
    string filename = "faculties.json";
    if(prompt)
        while(true)
        {
            filename = PromptString("Enter the name of the file:", "Filename cannot be empty");
            if(!File.Exists(filename)) {
                Console.Error.WriteLine("File doesnt exist");
                continue;
            }
            break;
        }

    StreamReader reader = new StreamReader(filename);
    string record = reader.ReadToEnd();

    faculties = JsonConvert.DeserializeObject<Dictionary<string, Faculty>>(record);
    reader.Close();
    Console.WriteLine("Faculties has been loaded");

    // bool skipHeader = true;
    // while(!reader.EndOfStream){
    //     string line = reader.ReadLine();
    //     if(skipHeader)
    //     {
    //         skipHeader = false;
    //         continue;
    //     }

    //     string[] fields = line.Split(",");
    //     List<string> courses = fields[2].Split(";").ToList();
    //     Faculty faculty = new Faculty(fields[0], fields[1], courses);
    //     faculties.Add(fields[0], faculty);
    // }

    // reader.Close();
    // Console.WriteLine("Faculties has been loaded");


}

ReadAndLoadDataFromFile(false); //load the files in at the first load
while(true)
{
    switch(MenuSelection())
    {
        case "1":
            PromptForFaculty();
            break;
        case "2":
            foreach(KeyValuePair<string,Faculty> faculty in faculties){
                Console.WriteLine(faculty.Value);
            }
        break;
        case "3":
            ReadAndLoadDataFromFile(true);
            //implement load from file soon
        break;
        case"4":
            WriteToFile();
        break;
      

    }
}
