public interface IOrderState
{
    void Handle(OrderContext context);
}

public class NewOrderState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Order is new.");
        // Transition to ProcessingState
        context.SetState(new ProcessingState());
    }
}

public class ProcessingState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Order is being processed.");
        // Transition to ShippedState or CancelledState
        if (context.IsPaymentConfirmed)
        {
            context.SetState(new ShippedState());
        }
        else
        {
            context.SetState(new CancelledState());
        }
    }
}

public class ShippedState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Order has been shipped.");
        // Transition to DeliveredState or ReturnedState
        if (context.IsDelivered)
        {
            context.SetState(new DeliveredState());
        }
        else if (context.IsReturned)
        {
            context.SetState(new ReturnedState());
        }
    }
}

public class DeliveredState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Order has been delivered.");
        // Transition to CompletedState
        context.SetState(new CompletedState());
    }
}

public class CompletedState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Order is completed.");
        // No further transitions
    }
}

public class CancelledState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Order has been cancelled.");
        // No further transitions
    }
}

public class ReturnedState : IOrderState
{
    public void Handle(OrderContext context)
    {
        Console.WriteLine("Order has been returned.");
        // Transition to ProcessingState or CancelledState
        if (context.IsReshipped)
        {
            context.SetState(new ProcessingState());
        }
        else
        {
            context.SetState(new CancelledState());
        }
    }
}

// Ejemplo de uso de la clase OrderContext
public class OrderContext
{
    public bool IsPaymentConfirmed { get; set; }
    public bool IsDelivered { get; set; }
    public bool IsReturned { get; set; }
    public bool IsReshipped { get; set; }

    private IOrderState _currentState;

    public OrderContext(IOrderState initialState)
    {
        _currentState = initialState;
    }

    public void SetState(IOrderState state)
    {
        _currentState = state;
    }

    public void Request()
    {
        _currentState.Handle(this);
    }
}