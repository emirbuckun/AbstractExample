namespace AbstractExample
{
  class MoneyTransfer : Payment
  {
    public int IbanNo { get; set; }
    public MoneyTransfer(int ibanNo, string firstName, string lastName, double paymentTotal)
    : base(firstName, lastName, paymentTotal) { IbanNo = ibanNo; }

    public override void SendPayment()
    {
      Console.WriteLine("MoneyTransfer Class Send Payment");
    }
  }
}