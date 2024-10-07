namespace BallSimple;

public class Ball
{
    public static Ball throwBallTo(string direction)
    {
        return new Ball(direction);
    }
    
    public Ball(string movementDirection)
    {
        this.direction = movementDirection;
    }
    
    private string direction;
    
    public string Direction()
    {
        return this.direction;
    }
    
    public void bounce()
    {
        //TODO: Implement bounce
    }
}