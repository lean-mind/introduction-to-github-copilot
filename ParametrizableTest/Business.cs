namespace ParametrizableTest;

public enum MarketState
{
    Crisis,
    Normal,
    Euphoria
}

public class Business(int valuationAtMarketInCrisis, int valuationAtMarketNormal, int valuationAtMarketInEuphoria)
{
    public int ValuationAtMarketState(MarketState marketState)
    {
        return valuationAtMarketInCrisis;
    }
}