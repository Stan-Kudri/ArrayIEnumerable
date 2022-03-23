using System.Collections;

namespace ArrayIEnumerable
{
    public class CandyEnumerator : IEnumerator<Candy>
    {
        private readonly Candy[] _product;
        private int index = -1;

        public CandyEnumerator(Candy[] product)
        {
            _product = product;
        }

        public Candy Current
        {
            get
            {
                return _product[index];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            return index++ < _product.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
