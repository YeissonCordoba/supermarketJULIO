
namespace supermarket
{
    public class FixedPriceProduct : Product
    {
        public override decimal ValueToPay()
        {
            return (Price * (decimal)Tax) + Price;
        }
        public override string ToString()
        {
            return $"**Productos con Precio Fijo**\n {base.ToString()}\n\tValor.........:\t{$"{ValueToPay():c2}",15}";
        }
    }
}