namespace supermarket
{
    public class Invoice : IPay

    {
        List<Product> _products = new List<Product>();

        public Invoice()
        {

        }
        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal invoiceT = 0;

            foreach (Product Market in _products)
            {
                invoiceT += Market.ValueToPay();
            }
            return invoiceT;
        }

        public override string ToString()
        {
            string listP = ("");

            foreach (Product Market in _products)
            {
                listP += Market.ToString()+"\n";
            }
            Console.WriteLine(" RECEIPT");
            Console.WriteLine(" -------------------------------------------------");
            return $"{listP}\n\t               ===============\n\tTOTAL.........:\t{$"{ValueToPay():c2}",15}";
        }
    }
}
