// See https://aka.ms/new-console-template for more information
public class Loan
{
    public int Id { get; set; }
    public string LoanHolder { get; set; }
    public double Amount { get; set; }
    public int PaymentNumber { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }

    public Loan(int id, string loanHolder, double amount, int paymentNumber, DateTime start, DateTime end)
    {
         Id = id;
         LoanHolder = loanHolder;
         Amount = amount;
         PaymentNumber = paymentNumber;
         Start = start;
         End = end;
    }


}