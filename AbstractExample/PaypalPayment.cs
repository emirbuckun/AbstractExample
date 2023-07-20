namespace AbstractExample
{
  class PaypalPayment : Payment, IContactless, IQRCode
  {
    public int PaypalAccountNo { get; set; }
    public PaypalPayment(int paypalAccountNo, string firstName, string lastName, double paymentTotal)
    : base(firstName, lastName, paymentTotal)
    {
      PaypalAccountNo = paypalAccountNo;
    }

    public override void SendPayment()
    {
      Console.WriteLine("PaypalPayment Class Send Payment");
    }

    public void ReadQRCode()
    {
      throw new NotImplementedException();
    }

    public void PaymentContactless()
    {
      throw new NotImplementedException();
    }
  }
}