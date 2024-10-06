using Domain;

namespace ExternalServices;

public interface EmailSender
{
    public void sendConfirmationEmailTo(Customer customer);
}