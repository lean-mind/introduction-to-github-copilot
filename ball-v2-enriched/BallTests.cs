namespace BallEnriched;

public class BallTests
{
    [Theory]
    [InlineData("South", "North")]
    [InlineData("North", "South")]
    [InlineData("East", "West")]
    [InlineData("West", "East")]
    public void ball_when_bounces_with_some_wall_goes_to_opposite_direction(string directionBeforeBounce, string directionAfterBounce)
    {
        var ball = Ball.throwBallTo(directionBeforeBounce);
        
        ball.bounce();
        
        Assert.Equal(directionAfterBounce, ball.Direction());
    }
}