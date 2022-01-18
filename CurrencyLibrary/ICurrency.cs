using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyLibrary
{
    public interface ICurrency
    {
        string Name { get; }
        decimal Value { get; }
    }
}