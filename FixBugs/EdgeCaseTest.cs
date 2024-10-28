using FluentAssertions;

namespace simple_division;

public class EdgeCaseTest
{
    [Fact]
    public void division_by_zero_should_not_be_allow()
    {
        var dividend = 2;
        var divisor = 0;
        
        Assert.Throws<DivideByZeroException>(
            () => Math.Divide(dividend, divisor)
        ).Message.Should().Be("Divisor cannot be zero. Please try again");
    }
}