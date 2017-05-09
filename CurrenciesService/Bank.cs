using System;
using System.Collections;
using System.Collections.Generic;

namespace CurrenciesService
{
    public class Bank
    {
        private readonly Dictionary<Pair, int> _rates;
        public Bank()
        {
            _rates = new Dictionary<Pair, int>();
        }
        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }
        public int GetRate(string from, string to)
        {
            if (from.Equals(to)) 
            {
                return 1;
            }
            return _rates[new Pair(from, to)];
        }

        public void AddRate(string from, string to, int rate)
        {
            var pair = new Pair(from, to);
            if (_rates.ContainsKey(pair))
            {
                _rates[pair] = rate;
            }
            else
            {
                _rates.Add(pair, rate);
            }
        }
    }
}