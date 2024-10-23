namespace ParametrizableTest;

public enum MarketState
{
    Crisis,
    Normal,
    Euphoria
}

public class Business(int valuationAtMarketInCrisis, int ValuationAtMarketNormal, int valuationAtMarketInEuphoria)
{
    public int valuationAtMarketState(MarketState marketState)
    {
        return valuationAtMarketInCrisis;
    }
}