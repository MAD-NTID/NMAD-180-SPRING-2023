Dictionary<string, Bank> banks = new Dictionary<string, Bank>();

string[] menus = {"Add a new bank", "Show all banks", "Add new customer"};

while(true)
{
    for(int i = 0; i < menus.Length; i++) {
        Console.WriteLine($"{i+1}. {menus[i]}");
    }

    Console.Write("Selection:");
    string selection = Console.ReadLine();

    switch(selection)
    {
        case "1":
            AddNewBank();
            break;
        case "2":
            ShowAllBanks();
            break;
        
        case "3":
            AddCustomer();
            break;

        default:
            Console.WriteLine($"Invalid selection!!! Please select 1-{menus.Length}");
            break;
    }
}

string PromptForBankName()
{

    while(true) {
        Console.Write("Enter the name of the bank:");
        string bank = Console.ReadLine();
        if(string.IsNullOrEmpty(bank))  {
            Console.WriteLine("Bank name cannot be null or empty");
            continue;
        }

        if(!banks.ContainsKey(bank)) {
            Console.WriteLine("The bank doesnt exist!");
            continue;
        }

        return bank;
    }
}

string PromptForCustomerName()
{
        
    while(true)
    {
        
        Console.Write("Enter the customer's name:");
        string name = Console.ReadLine();
        if(string.IsNullOrEmpty(name)){
            Console.WriteLine("Customer's name cannot be empty");
            continue;
        }

        return name;
    }
}

int PromptForCustomerAccountNumber()
{
    
    while(true)
    {
        Console.Write("Enter customer's account number:");
        string account = Console.ReadLine();
        if(!int.TryParse(account, out int number) || number <=0 || account.Length < 5)
        {
            Console.WriteLine("account numbers must be 5 digits");
            continue;
        }

        return number;
    }
}

double PromptForCustomerBalance()
{
    
    while(true)
    {
        Console.Write("Account balance:");
        if(!double.TryParse(Console.ReadLine(), out double balance) || balance < 0){
            Console.WriteLine("Balance must be  >=0");
            continue;
        }

        return balance;
    }
}
void AddCustomer()
{
    string bankName = PromptForBankName();
    string customer = PromptForCustomerName();
    int number = PromptForCustomerAccountNumber();
    double balance = PromptForCustomerBalance();

    Account account = new Account(customer, number, balance);
    Bank bank = banks[bankName];

    bank.AddNewCustomer(account);
    Console.WriteLine($"{customer} was successfully added to {bankName}");

}

void ShowAllBanks()
{
    foreach(string name in banks.Keys){
        Console.WriteLine(banks[name]);
    }
}

void AddNewBank()
{
    while(true){
        Console.Write("Enter the name of the bank:");
        string name = Console.ReadLine();

        if(string.IsNullOrEmpty(name)) {
            Console.Error.WriteLine("The bank's name cannot be null or empty");
            continue;
        }

        //bank's name is validated so we will add it and exit the bank's name loop
        Bank bank = new Bank(name);
        banks.Add(name, bank);
        Console.WriteLine($"{name} was successfully added to the list of banks");
        break;
    }
}
