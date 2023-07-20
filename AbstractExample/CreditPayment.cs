using AbstractExample;

class CreditPayment : Payment, IContactless, IQRCode
{
  public string? CreditCardNumber { get; set; }
  public int Cvv { get; set; }
  public string? YearAndMonth { get; set; }
  public CreditPayment(string cardNumber, int cvv, string yearAndMonth,
  string firstName, string lastName, double paymentTotal)
  : base(firstName, lastName, paymentTotal)
  {
    CreditCardNumber = cardNumber;
    Cvv = cvv;
    YearAndMonth = yearAndMonth;
  }
  public override void SendPayment()
  {
    Console.WriteLine("CreditPayment Class Send Payment");
  }

  public void PaymentContactless()
  {
    throw new NotImplementedException();
  }

  public void ReadQRCode()
  {
    throw new NotImplementedException();
  }
}