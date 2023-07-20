abstract class Payment
{
  public string? FirstName { get; set; }
  public string? LastName { get; set; }
  public double PaymentTotal { get; set; }
  public Payment() { }
  public Payment(string firstName, string lastName, double paymentTotal)
  {
    FirstName = firstName;
    LastName = lastName;
    PaymentTotal = paymentTotal;
  }
  public abstract void SendPayment();
}