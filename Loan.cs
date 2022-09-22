// See https://aka.ms/new-console-template for more information
public class Loan
{
    public int Id { get; set; }
    public Customer LoanOwner { get; }
    public int Amount { get; }
    public int PaymentNumber { get; }
    public DateTime Start { get; }
    public DateTime End { get; set; }

    public Loan(Customer loanOwner, int amount, int paymentNumber, DateTime start)
    {
         this.LoanOwner = loanOwner;
         this.Amount = amount;
         this.PaymentNumber = paymentNumber;
         this.Start = start;
         this.End = endPayment();
    }

    public DateTime endPayment()
    {
        End = Start.AddMonths(Amount / PaymentNumber);
        return End;
    }

}