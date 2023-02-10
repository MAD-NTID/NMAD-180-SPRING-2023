Console.WriteLine("===========================");
Console.WriteLine("          ATM              ");
Console.WriteLine("===========================");


const int PIN = 3639;
const int DEPOSIT = 1;
const int CHECK = 2;
const int WITHDRAW = 3;

double balance = 50000;

Console.WriteLine("Welcome to ATM");

//prompt the user for the pin
Console.Write("Enter your pin:");

bool canConvertPinToInt = int.TryParse(Console.ReadLine(), out int accountPin);

//was the value successfully converted to an int?
if(canConvertPinToInt)//if(canConvertPinToInt == true) is the same thing
{
    //Check for correct pin
    if(PIN==accountPin)
    {
        //show Account options
        Console.WriteLine("Here is your account info\n");
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Check Balance");
        Console.WriteLine("3. Withdraw money");

        //allow the user to select an option
        Console.Write("please pick an option(1-3):");
        int choice = int.Parse(Console.ReadLine());

        //handle each selections
        //deposit money
        if(choice==DEPOSIT)
        {
            //ask user to put down how much money they want to put down
            Console.Write("How much money would you like to deposit:");
            double amountDeposit = double.Parse(Console.ReadLine());

            //add the amount deposit to the balance
            balance = balance + amountDeposit;

            Console.WriteLine($"Your balance is now:{balance:C}");
        } 
        //check balance
        else if(choice == CHECK) {
            Console.WriteLine($"Your balance is:{balance:C}");
        }
        //rob the bank
        else if(choice==WITHDRAW){
            Console.Write("How much do you want to rob:");
            double withdraw = double.Parse(Console.ReadLine());

            //validate withdraw amount
            if(withdraw > balance)
                Console.WriteLine("Insufficent fund!!!");
            else {

                balance = balance - withdraw;
                Console.WriteLine($"Your balance is now:{balance:C}");
            }

        }

        //invalid choice
        else {
            Console.WriteLine("Invalid selection!");
        }


    }
    else
        Console.WriteLine("Try again with the right pin");
}
else {
    //the conversion failed
    Console.WriteLine("Please enter numbers!!!!");
}







