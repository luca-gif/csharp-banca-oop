// See https://aka.ms/new-console-template for more information
public class Loan
{

    public Loan(int id, string loanHolder, int amount, int paymentNumber, string start, string end)
    {
        int Id = id;
        string LoanHolder = loanHolder;
        int Amount = amount;
        int PaymentNumber = paymentNumber;
        string Start = start;
        string End = end;
    }

    public int Id { get; set; }

    public string LoanHolder { get; set; }

    public int Amount { get; set; }

    public int PaymentNumber { get; set; }

    public string Start { get; set; }

    public string End { get; set; }
}