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
            return $"{base.ToString()}\n\tProducts......:\t" +
                $"{listP}\n\tDiscount......:\t{$"{Discount:p2}",15}\n\t" +
                $"Value.........:\t{$"{ValueToPay():c2}",15}";
        }
    }
}