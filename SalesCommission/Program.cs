//Make 2 constant variables
const double SEVEN_PERCENTAGE = .07;
const double SET_MINIMUM_LIMIT = 10000;
const double NO_COMMISSION = 0;
const double TEN_PERCENTAGE = .1;
const double SET_MINIMUM_LIMIT_100k = 100000;

//ask the user for the total sales
Console.Write("What is your sale? ");
double saleAmount = double.Parse(Console.ReadLine());


//check if the sale amount is greater than or equal to the minimum amount for commission
if(saleAmount>=SET_MINIMUM_LIMIT && saleAmount < SET_MINIMUM_LIMIT_100k)
{
    double saleCommission = saleAmount * SEVEN_PERCENTAGE;
    Console.WriteLine($"Your sale  commission amount is {saleCommission:C}");
} else if(saleAmount >=SET_MINIMUM_LIMIT_100k){
    double saleCommission = saleAmount * TEN_PERCENTAGE;
    Console.WriteLine($"Your sale  commission amount is {saleCommission:C}");
}
else {
    Console.WriteLine($"Your sale  commission amount is {NO_COMMISSION:C}");
}

