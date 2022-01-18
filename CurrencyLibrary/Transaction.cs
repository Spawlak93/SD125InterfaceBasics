using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public class Transaction
    {
        private readonly List<ICurrency> _currencies = new List<ICurrency>();

        public Transaction(decimal totalAmount)
        {
            TotalAmount = totalAmount;
        }

        public decimal TotalAmount { get; }

        public decimal AmountPayed
        {
            get
            {
                decimal totalValue = 0;
                foreach (ICurrency currency in _currencies)
                {
                    totalValue += currency.Value;
                }
                return totalValue;
            }
        }

        public decimal AmountOwed
        {
            get
            {
                return TotalAmount - AmountPayed;
            }
        }

        public DateTime DateOfTransaction { get; set; }

        //Make Payment method
        public void MakePayment(ICurrency payment)
        {
            _currencies.Add(payment);
        }

        public void MakePayment(params ICurrency[] payments)
        {
            foreach (ICurrency currency in payments)
            {
                _currencies.Add(currency);
            }
        }

        public void MakePayment(int numberOfCurrency, ICurrency currency)
        {
            for(int i = 0; i < numberOfCurrency; i++)
            {
                _currencies.Add(currency);
            }
        }

        //Get payments used
    }
}