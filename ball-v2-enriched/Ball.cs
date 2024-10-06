namespace BallV2Enriched;

public class Direction
{
    private string[] validDirections = new[] { "North", "South", "East", "West" };
    private string value;
    public Direction(string value)
    {
        this.assertIsValidDirection(value);
        this.value = value;
    }
    
    public string Value()
    {
        return this.value;
    }

    private void assertIsValidDirection(string direction)
    {
        var notValidDirection = !validDirections.Contains(direction);
        if (notValidDirection)
        {
            throw new Exception("Invalid direction");
        }
    }
}

public class Ball
{
    private Direction direction;

    public Ball(Direction direction)
    {
        this.direction = direction;
    }

    public static Ball throwBallTo(string direction)
    {
        return new Ball(new Direction(direction));
    }

    public void bounce()
    {
        //TODO: Implement bounce
    }
    
    public string Direction()
    {
        return this.direction.Value();
    }
}