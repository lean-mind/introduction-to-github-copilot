using LegacylogisticsSystem;

namespace LegacyLogiticsSystemTests;

public class OrderTests
{
    [Fact]
    public void ShippingCostIsCalculatedCorrectlyForExpress()
    {
        var order = new Order("Express");
        var cost = order.CalculateCost(10, 100);
        Assert.Equal(110, cost);
    }

    [Fact]
    public void ShippingCostIsCalculatedCorrectlyForRegular()
    {
        var order = new Order("Regular");
        var cost = order.CalculateCost(10, 100);
        Assert.Equal(82, cost);
    }

    [Fact]
    public void ShippingCostIsCalculatedCorrectlyForEconomical()
    {
        var order = new Order("Economical");
        var cost = order.CalculateCost(10, 100);
        Assert.Equal(60, cost);
    }

    [Fact]
    public void ThrowsArgumentExceptionForInvalidShippingType()
    {
        var order = new Order("InvalidType");
        Assert.Throws<ArgumentException>(() => order.CalculateCost(10, 100));
    }
}