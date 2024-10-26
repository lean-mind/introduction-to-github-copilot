using FluentAssertions;

namespace simple_division;

public class HappyPathTest
{
    [Fact]
    public void divide_positive_numbers_returns_expected_quotient()
    {
        var dividend = 10;
        var divisor = 2;
        
        var result = Math.Divide(dividend, divisor);
        
        result.Should().Be(5);
    }
}