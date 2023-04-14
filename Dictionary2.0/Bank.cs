public class Bank
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    private Dictionary<int, Account> customers;
    public Dictionary<int, Account> Customers
    {
        get { return customers; }
        set { customers = value; }
    }

    public Bank(string name)
    {
        Name = name;
        Customers = new Dictionary<int, Account>();
    }

    public void AddNewCustomer(Account customer)
    {
        Customers.Add(customer.Number, customer);
    }

    public bool DepositMoney(int accountNumber, double amountToDeposit)
    {
        //check if the account number exist
        if(Customers.ContainsKey(accountNumber))
            return false;

        Account customer = Customers[accountNumber];
        customer.Deposit(amountToDeposit);
        return true;
    }

    override
    public string ToString()
    {
        string customersString = "\nCustomers:";
        foreach(KeyValuePair<int, Account> customer in Customers)
        {
            customersString+= "\n" + "\t" + customer.Value;
        }

        return $"Bank:{Name} " + customersString;
    }
    
    
}