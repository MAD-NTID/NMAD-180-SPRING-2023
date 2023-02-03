//Hard coded the seconds
// int minutes = 0;
// const int SECONDS_TO_MINUTES = 60;

// int seconds = 200;

// minutes = SECONDS_TO_MINUTES * seconds;
// Console.WriteLine("{0} seconds is {1} minutes", seconds, minutes);
// Console.WriteLine(""+seconds+" is "+minutes+ " minutes");
// Console.WriteLine($"{seconds} seconds is {minutes} minutes");

// Console.Write("Enter your name:");
// string name = Console.ReadLine();

// Console.WriteLine("Welcome {0}", name);

//User Inputs

// const int SECONDS_TO_MINUTES = 60;
// Console.Write("Enter the number of second(s):");
// double seconds = double.Parse(Console.ReadLine());

// double minutes = SECONDS_TO_MINUTES * seconds;

// Console.WriteLine("{0} seconds is {1} minutes", seconds, minutes);
// Console.WriteLine(""+seconds+" is "+minutes+ " minutes");
// Console.WriteLine($"{seconds} seconds is {minutes} minutes");


const double CHIP_COST = 2.0;
const double NY_STATE_TAX = .10;

Console.Write("Enter # of chips:");
int chips = int.Parse(Console.ReadLine());

double subTotal = CHIP_COST * chips;
double tax = subTotal * NY_STATE_TAX;
double finalTotal = subTotal + tax;

Console.WriteLine("# of chips: {0}", chips);
Console.WriteLine("subtotal:{0:C}", subTotal);
Console.WriteLine("tax:{0:C}", tax);
Console.WriteLine("Final Total: {0:C}", finalTotal);;




