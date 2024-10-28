using LegacylogisticsSystem;

namespace LegacyLogiticsSystemTests;

public class OrderTests
{
    [Fact]
    public void ShippingCostIsCalculatedCorrectlyForExpress()
    {
        var order = new Order();
        order.SetShippingType("Express");
        
        var cost = order.CalculateCost(10, 100);
        
        Assert.Equal(110, cost);
    }

    [Fact]
    public void ShippingCostIsCalculatedCorrectlyForRegular()
    {
        var order = new Order();
        order.SetShippingType("Regular");
        
        var cost = order.CalculateCost(10, 100);
        
        Assert.Equal(82, cost);
    }

    [Fact]
    public void ShippingCostIsCalculatedCorrectlyForEconomical()
    {
        var order = new Order();
        order.SetShippingType("Economical");
        
        var cost = order.CalculateCost(10, 100);
        
        Assert.Equal(60, cost);
    }

    [Fact]
    public void ShouldNotAllowInvalidShippingType()
    {
        var order = new Order();
        order.SetShippingType("Invalid");
        
        Assert.Throws<ArgumentException>(() => order.CalculateCost(10, 100));
    }
    
    [Fact]
    public void ShouldNotAllowTheCalculationWithoutSettingAShippingType()
    {
        var order = new Order();
        
        Assert.Throws<ArgumentException>(() => order.CalculateCost(10, 100));
    }
}