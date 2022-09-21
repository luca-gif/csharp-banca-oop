// See https://aka.ms/new-console-template for more information
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
        int customerIndex = 0;

        foreach (Customer customer in Customers)
        {
            if(customer == customerToEdit) customerIndex = Customers.IndexOf(customer);
                            
        }

        Customers[customerIndex] = customerEdited;
    }
}



