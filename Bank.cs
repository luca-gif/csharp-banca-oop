// See https://aka.ms/new-console-template for more information
using System;

public class Bank
{
    string Name { get; }
    
    public List<Customer> Customers { get; set; }

    public List<Loan> Loans { get; set; }

    public Bank(string name, List<Customer> customers, List<Loan> loan)
    {
        this.Name = name;
        this.Customers = customers;
        this.Loans = loan;
    }   

}



