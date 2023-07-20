namespace AbstractExample
{
  internal class Program
  {
    // Enum Example
    enum Days
    {
      Monday = 1,
      Tuesday = 18,
      Wednesday = 3,
      Thursday = 4,
      Friday = 5,
      Saturday = 6,
      Sunday = 7
    }

    enum UserStatus
    {
      Online = 1,
      Offline = 2,
      InMeeting = 3,
    }

    private static void Main()
    {
      Console.WriteLine("Choose a payment method.");
      Console.WriteLine("1. Credit Card");
      Console.WriteLine("2. Money Transfer");
      Console.WriteLine("3. Paypal");

      byte paymentType = Convert.ToByte(Console.ReadLine());
      MakePayment(paymentType);

      CreditPayment creditPayment = new("1234", 123, "12/26", "Emir", "Büçkün", 12345);
      MakePayment(creditPayment);

      MoneyTransfer moneyTransfer = new(12345, "Emir", "Büçkün", 0);
      MakePayment(moneyTransfer);

      PaypalPayment paypalPayment = new(12345, "Emir", "Büçkün", 0);
      MakePayment(paypalPayment);

      // Struct Example
      StructSample structSample = new(1, 2, true, creditPayment);
      structSample.SampleMethod();

      // Enum Example
      DateTime dateTime = DateTime.Now;
      if (dateTime.Day == (int)Days.Tuesday)
        Console.WriteLine("Today is tuesday!");

      int userStatus = 2;
      if (userStatus == 2)
        Console.WriteLine($"User is {UserStatus.Online}!");
    }

    private static void MakePayment(byte type)
    {
      if (type == 1) CreditCardPayment();
      else if (type == 2) MoneyTransferPayment();
      else if (type == 3) PaypalPayment();
      else Console.WriteLine($"Incorrect type: {type}");
    }

    private static void MakePayment(Payment payment)
    {
      payment.SendPayment();
    }

    private static void CreditCardPayment()
    {
      Console.WriteLine("Credit Card Payment Completed");
    }

    private static void MoneyTransferPayment()
    {
      Console.WriteLine("Money Transfer Payment Completed");
    }

    private static void PaypalPayment()
    {
      Console.WriteLine("Paypal Payment Completed");
    }
  }
}