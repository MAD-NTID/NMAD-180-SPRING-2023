public class Account
{
    private int number;
    public int Number
    {
        get { return number; }
        set { number = value; }
    }

    private string owner;
    public string Owner
    {
        get { return owner; }
        set { owner = value; }
    }

    private double amount;
    public double Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    public Account(string name, int number, double amount)
    {
       Amount = amount;
       Number = number;
       Owner = name;
        
    }

    /**
        This method will checks wether the balance is empty
    **/
    public bool IsEmpty()
    {
        return amount == 0;
    }

    /**
        This method will take a specific amount and deposit it to the balance
    **/
    public void Deposit(double depositAmount)
    {
        amount+=depositAmount;
    }

    override
    public string ToString()
    {
        return $"Account:{Number} Name:{Owner} Balance: {Amount:C}";
    }


    
    
    
}