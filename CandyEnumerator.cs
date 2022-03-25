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
        }

        public bool MoveNext()
        {
            if (index + 1 >= _product.Length)
                return false;
            index++;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
