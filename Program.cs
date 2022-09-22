
List<Customer> customers = new List<Customer>(); //Lista Clienti
List<Loan> loans = new List<Loan>(); //Lista Prestiti

Bank myBank = new Bank("Intesa", customers, loans);

Customer customer1 = new Customer("Luca", "Rossi", "d10d10", 15000);
Customer customer2 = new Customer("Marco", "Verdi", "d15d15", 25000);

myBank.Customers.Add(customer1);
myBank.Customers.Add(customer2);

myBank.Loans.Add(new Loan(customer1, 44500, 8, new DateTime(2022, 8, 20)));
myBank.Loans.Add(new Loan(customer2, 31500, 11, new DateTime(2022, 11, 02)));

// Faccio scegliere allo user cosa fare

start: 

Console.WriteLine(" ");
Console.WriteLine("Clienti o prestiti?");
string command = Console.ReadLine();

if(command == "clienti")
{
    Console.WriteLine("Cosa vuoi fare? (aggiungere, modificare o cercare)");
    string choose = Console.ReadLine();

    if(choose == "aggiungere")
    {
        addCustomer();
    }
    else if(choose == "modificare")
    {
        editCustomer();
    }
    else if (choose == "cercare")
    {
        findCustomer();
    }
    else
    {
        Console.WriteLine("Inserisci una risposta valida");
        goto start;
    }
    goto start;
}
else if(command == "prestiti")
{
    Console.WriteLine("Vuoi crearne uno nuovo o cercarne uno esistente? (creare o cercare)");
    string choose = Console.ReadLine();

   if(choose == "creare")
    {
        Console.WriteLine("Inserisci il codice fiscale del cliente");
        string codice;
        codice = Console.ReadLine();

        addLoan(codice);
    }
   else if(choose == "cercare")
    {
        Console.WriteLine("Inserisci il codice fiscale del cliente");
        string codice = Console.ReadLine();

        findLoan(codice);
    }
}


//Funzione che aggiunge un nuovo cliente

void addCustomer()
{
    Console.WriteLine("Inserisci il nome"); //chiedo di inserire il nome
    string name = Console.ReadLine();

    Console.WriteLine("Inserisci il cognome"); //chiedo di inserire il cognome
    string lastname = Console.ReadLine();

    Console.WriteLine("Inserisci il codice fiscale"); //chiedo di inserire il CF
    string fiscalCode = Console.ReadLine();

    Console.WriteLine("Inserisci lo stipendio"); //chiedo di inserire lo stipendio
    int salary = Convert.ToInt32(Console.ReadLine());

    Customer newCustomer = new Customer(name, lastname, fiscalCode, salary);

    myBank.Customers.Add(newCustomer);
}


//Funzione che modifica un cliente

void editCustomer()
{
    Console.WriteLine("Inserisci il Codice Fiscale del cliente");
    string cf = Console.ReadLine();

    foreach (Customer customer in customers)
    {
        if (customer.FiscalCode == cf)
        {

            Console.WriteLine("Cosa vuoi modificare? (nome, cognome, cf, o stipendio)");
            string choose = Console.ReadLine();

            if (choose == "nome")
            {
                Console.WriteLine("Inserisci il nuovo nome");
                customer.Name = Console.ReadLine();
            }
            else if (choose == "cognome")
            {
                Console.WriteLine("Inserisci il nuovo cognome");
                customer.Lastname = Console.ReadLine();
            }
            else if (choose == "cf")
            {
                Console.WriteLine("Inserisci il nuovo codice fiscale");
                customer.FiscalCode = Console.ReadLine();
            }
            else if (choose == "stipendio")
            {
                Console.WriteLine("Inserisci il nuovo stipendio");
                customer.Salary = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Inserisci un parametro valido");
            }
        }
        else
        {
            Console.WriteLine("Cliente non trovato");
        }
    }
}



// Cercare cliente

 void findCustomer()
{
    Console.WriteLine("Inserisci il codice ficale");
    string cf = Console.ReadLine();

    foreach (Customer customer in customers)
    {
        if (customer.FiscalCode == cf)
        {
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Lastname);
        }
        
    }
}


// Creare prestiti

Console.WriteLine("Inserisci il Codice Fiscale del cliente");
string cf = Console.ReadLine();

void addLoan(string cf)
{
    foreach(Customer customer in customers)
    {
        if(customer.FiscalCode == cf)
        {
            Console.WriteLine("Inserisci il totale");
            int amount = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Inserisci il numero delle rate");
            int payment = Int32.Parse(Console.ReadLine());

            myBank.Loans.Add(new Loan(customer, amount, payment, DateTime.Now));
        }
    }
}

// Cercare prestiti

Console.WriteLine("Inserisci il Codice Fiscale del cliente");
string codiceFiscale = Console.ReadLine();

void findLoan(string codiceFiscale)
{
    int paymentToPay = 0;
    int loansQuantity = 1;

    foreach(Loan loan in loans)
    {
        if (loan.LoanOwner.FiscalCode == codiceFiscale)
        {
            Console.WriteLine($"{loan.LoanOwner.Name} ha {loansQuantity} prestito di {loan.Amount}€");
        }
    }
}

