﻿const string PASSWORD = "TOPSECRET";
const string USERNAME = "foo";

Console.Write("Enter the username:");
string username = Console.ReadLine();
Console.Write("Enter the password:");
string password = Console.ReadLine();

if(username == USERNAME && PASSWORD==password) {
    Console.WriteLine("Access granted");
} else {
    Console.WriteLine("Access denied!!");
}

if(username!=USERNAME || password!=PASSWORD)
{
    Console.WriteLine("Access denied!!");
} else 
{
    Console.WriteLine("Access granted");
}

if(!(username == USERNAME && password == PASSWORD)){
    Console.WriteLine("Access denied!!");
} else {
    Console.WriteLine("Access granted");
}
