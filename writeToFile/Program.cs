//the name of the file that we want to write to
string filename = "helloworld.txt";
bool append = false;

//set up a stream connection with the OS that we want to write to the specific file
StreamWriter writer = new StreamWriter(filename, append);

//write a new line to the file
writer.WriteLine("Hello NMAD-180. We are rocking this!!!");
writer.WriteLine("My name is Mr. Foo and I am a 3rd years student in NMAD.");
writer.WriteLine("I VOW TO ACE THIS THING!!! cue smoke coming out of the nose!!!");
writer.WriteLine("");
writer.WriteLine("Show me please!!!");

//use write instead of writeLine if you want to write the contents on the same line

//before closing, notify the user that the content was successfully written to the file
Console.WriteLine($"The content was successfully written to {filename}");


//we are done with the file so we close it and make it available for other
//resource that need access to the file
writer.Close();


while(true)
{
    Console.Write("Enter the filename:");
    filename = Console.ReadLine(); 
    if(!File.Exists(filename)) {
        Console.WriteLine($"The file {filename} was not found!");
        continue;
    }

    break;
}

//create a stream reader
StreamReader reader  = new StreamReader(filename);


//using while end of stream
while(!reader.EndOfStream) {
    string line = reader.ReadLine();
    Console.WriteLine($"{line}");
}

//remember to close when done
reader.Close();



