
// Console.Write("Enter a name:");
// string name = Console.ReadLine();


// switch (name)
// {
//     case "Erik":
//         Console.WriteLine("Welcome Erik");
//         break;
//     case "Justin":
//         Console.WriteLine("Welcome Justin");
//         break;
//     case "Eric":
//         Console.WriteLine("Welcome Eric");
//         break;
//     case "Osman":
//         Console.WriteLine("Welcome Osman");
//         break;
//     default:
//         Console.WriteLine("You are not a student of this class");
//         break;
// }


// Console.WriteLine("1. Update student record\n2. Delete a student record");
// Console.Write("Selection:");

// string choice = Console.ReadLine();
// Console.WriteLine($"you entered choice:{choice}");

// switch(choice)
// {
//     case "1":
//         Console.WriteLine("updating record");
//         break;
//     case "2":
//         Console.WriteLine("Deleting record");
//         break;
//     default:
//         Console.WriteLine("Invalid selection");
//         break;

// }


const string PIN = "2356";
double balance = 67812000;

//create atm menu
Console.WriteLine("===========================");
Console.WriteLine("          ATM              ");
Console.WriteLine("===========================");

Console.WriteLine("Welcome to ATM");

Console.Write("PIN:");
switch(Console.ReadLine())
{
    case PIN:
        Console.WriteLine("1. Deposit");
        Console.WriteLine("2. Check Balance");
        Console.WriteLine("3. Withdraw money");

        Console.Write("Choice:");
        switch(Console.ReadLine())
        {
            case "1":
                Console.Write("Deposit amount:");
                if(double.TryParse(Console.ReadLine(), out double amountDeposit) && amountDeposit > 0){
                    balance = balance + amountDeposit;
                    Console.WriteLine($"Your balance is:{balance:C}");
                }else if(amountDeposit <=0){
                    Console.WriteLine("Amount must be greater than 0");
                }
                else {
                    Console.WriteLine("Please enter $$$$$$!!!");
                }
                

            break;
            case "2":
                 Console.WriteLine($"Your balance is:{balance:C}");
            break;
            case "3":
                Console.Write("How much money do you want to withdraw:");
                double amountWithdraw;
               if(double.TryParse(Console.ReadLine(), out amountWithdraw)){
                    if(amountWithdraw > 0 && amountWithdraw <= balance){
                        balance = balance - amountWithdraw;
                        Console.WriteLine($"Your balance is:{balance:C}");
                    }
                    else if(amountWithdraw > balance)
                        Console.WriteLine("Insufficent fund!!");
                    else
                        Console.WriteLine("Positive balance only!");
               } else
                    Console.WriteLine("Really bruh? Numbers only!");
            break;
            default:
                Console.WriteLine("Invalid selection!");
                break;
        }
        break;
    default:
        Console.WriteLine("Invalid pin");
        break;
}