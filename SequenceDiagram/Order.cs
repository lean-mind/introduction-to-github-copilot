
public class Order_
{
    private string _shippingType; // Can be "Economical", "Regular" or "Express"
    

    public void SetShippingType(string shippingType)
    {
        _shippingType = shippingType;
    }

    public decimal CalculateCost(decimal weight, decimal distance)
    {
        decimal cost = 0;

        // Calculation of shipping cost based on the type of shipping
        if (_shippingType == "Express")
        {
            cost = (weight * 1.5m + distance * 0.75m) + 20;
        }
        else if (_shippingType == "Regular")
        {
            cost = (weight * 1.2m + distance * 0.6m) + 10;
        }
        else if (_shippingType == "Economical")
        {
            cost = (weight * 1.0m + distance * 0.5m);
        }
        else
        {
            throw new ArgumentException("Invalid shipping type");
        }

        return cost;
    }
}