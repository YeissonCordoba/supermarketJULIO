namespace supermarket

{
    class ComposedProduct : Product
    {
        public float Discount { get; set; }
        public List<Product> Products { get; set; }

        public override decimal ValueToPay()
        {
            decimal PriceT = 0;

            foreach (Product Market in Products)
            {
                PriceT = PriceT + Market.ValueToPay();
            }
            return PriceT - (PriceT * (decimal)Discount);
        }


        public override string ToString()
        {
            string listP = null;

            foreach (Product Market in Products)
            {
                listP += Market.Description + ", ";
            };
            return $"**Productos con Precio Compuesto**\n{Id}\t{Description}\n\tProductos.....:\t{listP}\n\tDescuento.....:\t{$"{Discount:p2}",15}\n\tValor.........:\t{$"{ValueToPay():c2}",15}";
        }
    }
}