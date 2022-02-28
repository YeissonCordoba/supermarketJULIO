namespace supermarket
{
    public class Invoice : IPay

    {
        List<Product> _Products = new List<Product>();

        public Invoice()
        {

        }
        public void AddProduct(Product product)
        {
            _Products.Add(product);
        }

        public decimal ValueToPay()
        {
            decimal invoiceT = 0;

            foreach (Product Market in _Products)
            {
                invoiceT += Market.ValueToPay();
            }
            return invoiceT;
        }

        public override string ToString()
        {
            string listP = ("");

            foreach (Product Market in _Products)
            {
                listP += Market.ToString() + "\n ";
            }
            return $"**Factura**\n{listP}\n\t               ===============\n\tValor.........:\t{$"{ValueToPay():c2}",15}";
        }
    }
}
