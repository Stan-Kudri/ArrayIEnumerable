using System.Collections;

namespace ArrayIEnumerable
{
    public class Purchase : IEnumerable<Candy>
    {
        private readonly Candy[] _product;

        public Purchase(Candy[] product)
        {
            _product = new Candy[product.Length];
            Array.Copy(product, 0, _product, 0, product.Length);
        }

        public IEnumerator<Candy> GetEnumerator()
        {
            return new CandyEnumerator(_product);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
