namespace ParametrizableTest;

public class BusinessTests
{
    [Fact]
    public void should_be_valuated_according_to_market_state()
    {
        var business = new Business(100, 200, 300);
        
        var valuation = business.ValuationAtMarketState(MarketState.Crisis);
         
        Assert.Equal(100, valuation);
    }
}