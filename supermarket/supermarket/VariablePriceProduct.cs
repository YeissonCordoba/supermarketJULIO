namespace supermarket

{
    class VariablePriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            Price = (Price * (decimal)Quantity);
            return (Price * (decimal)Tax) + Price;
        }

        public string Measurement { get; set; }

        public float Quantity { get; set; }

        public override string ToString()
        {
            return $"**Productos con Precio Variable**\n{ base.ToString()}\n\tMedida........:\t{Measurement}\n\tCantidad......:\t{$"{Quantity:n2}",15}\n\tValor.........:\t{$"{ValueToPay():c2}",15}";
        }
    }

}