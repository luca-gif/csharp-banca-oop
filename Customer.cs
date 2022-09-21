// See https://aka.ms/new-console-template for more information
public class Customer
{
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string FiscalCode { get; set; }
    public int Salary { get; set; }

    public Customer(string name, string lastname, string fiscalCode, int salary)
    {
        this.Name = name;
        this.Lastname = lastname;
        this.FiscalCode = fiscalCode;
        this.Salary = salary;
    }

}