public class Properties : AbstractProperties
{
    public readonly int propertyPrice;
    public readonly int rentPrice;

    public Properties(int _propertyPrice, int _rentPrice)
    {
        propertyPrice = _propertyPrice;
        rentPrice = _rentPrice;
    }
}