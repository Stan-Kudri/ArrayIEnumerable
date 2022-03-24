using System.Collections;

namespace ArrayIEnumerable
{
    public class Purchase : IEnumerable<Candy>
    {
        private readonly Candy[] _product;

        public Purchase(Candy[] product)
        {
            Array.Copy(product, 0, _product = product, 0, _product.Length);
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
