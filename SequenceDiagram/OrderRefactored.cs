public class Order
{
    private IShippingStrategy _shippingStrategy;

    public void SetShippingStrategy(IShippingStrategy shippingStrategy)
    {
        _shippingStrategy = shippingStrategy;
    }

    public decimal CalculateCost(decimal weight, decimal distance)
    {
        if (_shippingStrategy == null)
        {
            throw new ArgumentException("Shipping strategy not set");
        }

        return _shippingStrategy.CalculateCost(weight, distance);
    }
}public interface IShippingStrategy
{
    decimal CalculateCost(decimal weight, decimal distance);
}

public class ExpressShippingStrategy : IShippingStrategy
{
    public decimal CalculateCost(decimal weight, decimal distance)
    {
        return (weight * 1.5m + distance * 0.75m) + 20;
    }
}

public class RegularShippingStrategy : IShippingStrategy
{
    public decimal CalculateCost(decimal weight, decimal distance)
    {
        return (weight * 1.2m + distance * 0.6m) + 10;
    }
}

public class EconomicalShippingStrategy : IShippingStrategy
{
    public decimal CalculateCost(decimal weight, decimal distance)
    {
        return (weight * 1.0m + distance * 0.5m);
    }
}