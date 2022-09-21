// See https://aka.ms/new-console-template for more information
public class Customer
{
        public Customer(string name, string lastname, string codiceFiscale, int salary)
    {
        this.Name = name;
        this.Lastname = lastname;
        this.CodiceFiscale = codiceFiscale;
        this.Salary = salary;
    }

    public string Name { get; set; }
    public string Lastname { get; set; }

    public string CodiceFiscale { get; set; }

    public int Salary { get; set; }
}