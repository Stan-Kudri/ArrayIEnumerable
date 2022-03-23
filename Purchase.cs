using System.Collections;

namespace ArrayIEnumerable
{
    public class Purchase : IEnumerable<Candy>
    {
        private readonly Candy[] _product;

        public Purchase(Candy[] product)
        {
            _product = new Candy[product.Length];
            for (var i = 0; i < product.Length; i++)
            {
                _product[i] = product[i];
            }
        }

        public IEnumerator<Candy> GetEnumerator()
        {
            return new CandyEnumerator(_product);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
