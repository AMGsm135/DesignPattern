public class MeliCart : ICriditCart
{

     public MeliCart(string ownerName)
    {
        OwnerName = ownerName;
        Amount = 0;
    }

    public string OwnerName { get; set; }

    public decimal Amount { get; set; }

    public void AddAmount(decimal amount)
    {
        this.Amount += amount;
    }

    public void GetAmount(decimal cost)
    {
        if(Amount > cost)
        {
            this.Amount-=cost;
        }
        System.Console.WriteLine("Not enough money");
    }

    public decimal GetSock()
    {
        return Amount;
    }
}