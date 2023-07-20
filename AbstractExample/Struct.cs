namespace AbstractExample
{
  internal readonly struct StructSample : IContactless
  {
    private readonly int width;
    private readonly int height;
    private readonly bool isError;
    private readonly CreditPayment creditPayment;

    public StructSample(int width, int height, bool isError, CreditPayment creditPayment)
    {
      this.width = width;
      this.height = height;
      this.isError = isError;
      this.creditPayment = creditPayment;
    }

    public readonly void SampleMethod()
    {
      Console.WriteLine($"Struct Sample: {width} {height} {isError} {creditPayment}");
    }

    public void PaymentContactless()
    {
      throw new NotImplementedException();
    }
  }
}