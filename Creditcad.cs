using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB6
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int CVV { get; set; }
        public double Balance { get; set; }

        public CreditCard(string cardNumber, string cardHolderName, DateTime expiryDate, int cvv, double balance)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpiryDate = expiryDate;
            CVV = cvv;
            Balance = balance;
        }
        public CreditCard() { }

        public void PrintCardInfo()
        {
            Console.WriteLine("Credit Card Information:");
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine($"Cardholder Name: {CardHolderName}");
            Console.WriteLine($"Expiry Date: {ExpiryDate}");
            Console.WriteLine($"CVV: {CVV}");
            Console.WriteLine($"Balance: ${Balance}");
        }

        public static CreditCard operator +(CreditCard left, int right)
        {
            return new CreditCard { Balance = left.Balance + right };
        }

        public static CreditCard operator -(CreditCard left, int right)
        {
            return new CreditCard { Balance = left.Balance - right };
        }

        public static bool operator !=(CreditCard left, CreditCard right)
        {
            return left.Balance != right.Balance;
        }

        public static bool operator ==(CreditCard left, CreditCard right)
        {
            return left.Balance == right.Balance;
        }

        public static bool operator >(CreditCard left, CreditCard right)
        {
            return left.Balance > right.Balance;
        }

        public static bool operator <(CreditCard left, CreditCard right)
        {
            return left.Balance < right.Balance;
        }
    }
}
