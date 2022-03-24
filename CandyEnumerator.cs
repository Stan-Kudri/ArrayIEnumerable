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
                index++;
                return _product[index];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            return index + 1 < _product.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
