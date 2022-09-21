// See https://aka.ms/new-console-template for more information
public class Bank
{
  
    public Bank(string name, List<Bank> customers, List<Bank> loan)
    {
        this.Name = name;
        this.Customers = customers;
        this.Loan = loan;
    }

    public string Name { get; set; }

    public List<Bank> Customers { get; set; }

    public List<Bank> Loan { get; set; }
}