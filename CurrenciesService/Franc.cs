using System;

namespace CurrenciesService
{
    public class Franc
    {
        private int _amount;
        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplicator)
        {
            return new Franc(_amount * multiplicator);
        }

        public override bool Equals(object obj)
        {
            var franc = obj as Franc;
            if (franc == null)
            {
                return false;
            }
            return _amount == franc._amount;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new System.NotImplementedException();
        }
    }
}
