namespace CurrenciesService
{
    class Pair
    {
        private readonly string _from;
        private readonly string _to;
        public Pair(string from, string to)
        {
            _from = from;
            _to = to;
        }

        // override object.Equals
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var pair = obj as Pair;
            if (pair == null)
            {
                return false;
            }
            return this._from.Equals(pair._from) && this._to.Equals(pair._to);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return 0;
        }
    }
}