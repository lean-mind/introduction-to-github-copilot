
using Domain;

public interface EmailSender
{
    public void sendConfirmationEmailTo(Customer customer);
}