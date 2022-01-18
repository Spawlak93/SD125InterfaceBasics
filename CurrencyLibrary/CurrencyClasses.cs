using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public class Penny : ICurrency
    {
        public string Name => "Penny";

        public decimal Value => 0.01m;
    }

    public class Dime : ICurrency
    {
        public string Name {get { return "Dime"; }}

        public decimal Value {get { return .1m; }}
    }

    public class Dollar : ICurrency
    {
        public string Name => "Dollar";

        public decimal Value => 1m;
    }

    public class ElectronicPayment : ICurrency
    {
        //asking for value for electronic payment
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }

        public string Name => "Electronic Payment";

        //No Setter so value cannot be changed
        public decimal Value { get; }
    }

    public class CanadianDollar : ICurrency
    {
        public string Name => "Canadian Dollar";

        public decimal Value => .8m;
    }

    public class Euro : ICurrency
    {
        public string Name => "Euro";

        public decimal Value => 1.13m;
    }

}