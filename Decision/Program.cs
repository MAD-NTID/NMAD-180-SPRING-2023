// const int END_OF_LIFE = 0;
// const int ONE_LIVE_LEFT = 1;
// const int TWO_LIVES_LEFT = 2;
// const int MAX_LIVES = 3;
// int lives;

// Console.Write("Enter the number of lives:");
// lives = int.Parse(Console.ReadLine());

// if(lives == MAX_LIVES)
// {
//     Console.ForegroundColor = ConsoleColor.Green;
//     Console.WriteLine("You are still alive");
//     Console.ResetColor();
// }
    
// else if(lives == TWO_LIVES_LEFT){
//     Console.ForegroundColor = ConsoleColor.Yellow;
//     Console.WriteLine("Your lives dropped down to 2");
//     Console.ResetColor();
// }
    
// else if(lives == ONE_LIVE_LEFT)
// {
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine("You are at risk, time to grab another heart!");
//     Console.ResetColor();
// }
    
// else
// {
//     Console.ForegroundColor = ConsoleColor.Gray;
//     Console.WriteLine(" * *");
//     Console.WriteLine(" --");
//     Console.WriteLine("You are dead bruh");
//     Console.ResetColor();
// }

//SPEED GUN
// const int ALLOW_ABOVE = 5;
// int currentSpeed = 0;
// int speedLimit = 0;
// int minimumSpeed = 0;


// Console.Write("Enter the speed limit: ");
// speedLimit = int.Parse(Console.ReadLine());

// Console.Write("Enter the minimum speed:");
// minimumSpeed = int.Parse(Console.ReadLine());

// Console.Write("Enter the speed of the car: ");
// currentSpeed = int.Parse(Console.ReadLine());


// if(currentSpeed > speedLimit  && currentSpeed >(speedLimit+ALLOW_ABOVE)) {
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine("SPEEDING!!!! Turn on da lights!");
//     Console.ResetColor();
// }

// else if(currentSpeed < minimumSpeed) 
// {
//     Console.WriteLine("Too slow");
// }
// else 
// {
//     Console.WriteLine("Not speeding... ");
// }



Console.Write("Weather:");
string weather = Console.ReadLine();

if(weather == "cloudy" || weather=="rainy" || weather=="Rainy") 
    Console.WriteLine("Bring an umbrella");
 else 
    Console.WriteLine("You dont need an umbrella");
