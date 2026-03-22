using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Lab05
{
    public static void Main()
    {
        IPaymentMethod method = new CreditCardPayment();
        method.Pay(100);
    }

    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
    public class CreditCardPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} with Credit Card");
        }
    }
    public class PayPalPayment : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount} with Credit Card");
        }
    }
    public class ReceiptSender
    {
        public void SendReceipt(string email, decimal amount)
        {
            Console.WriteLine($"Receipt for {amount} sent to {email}");
        }
    }
}
