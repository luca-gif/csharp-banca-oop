// See https://aka.ms/new-console-template for more information
using System;

public class Bank
{
    string Name { get; set; }

    List<Customer> Customers { get; set; }

    List<Loan> Loan { get; set; }

    public Bank(string name)
    {
        Name = name;
        Customers = new List<Customer>();
        Loan = new List<Loan>();
    }

    // Aggiungere nuovo cliente

    public void addNewCustomer(Customer newCustomer)
    {
        Customers.Add(newCustomer);
    }

    // Modificare cliente

    public void editCustomer(Customer customerToEdit, Customer customerEdited)
    {
        int index = 0;

        foreach (Customer customer in Customers)
        {
            if (customer == customerToEdit) index = Customers.IndexOf(customer);
            else Console.WriteLine("Questo cliente non esiste");
        }

        Customers[index] = customerEdited;
    }

    // Cercare cliente

    public void findCustomer(Customer customerToFind)
    {
        foreach (Customer customer in Customers)
        {
            if (Customers.Contains(customerToFind)) Console.WriteLine(customer);
            else Console.WriteLine("Cliente non trovato");
        }
    }

}



