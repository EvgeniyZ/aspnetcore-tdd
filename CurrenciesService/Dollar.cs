using System;

namespace CurrenciesService
{
    public class Dollar
    {
        private int _amount;
        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplicator)
        {
            return new Dollar(_amount * multiplicator);
        }

        public override bool Equals(object obj)
        {
            var dollar = obj as Dollar;
            if (dollar == null)
            {
                return false;
            }
            return _amount == dollar._amount;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
        }
    }
}
