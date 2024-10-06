using ExternalServices;

namespace UseCaseWithoutContext;

public class RegisterCustomerWithContext(CustomerRepository customerRepository, EmailSender emailSender)
{
    private CustomerRepository customerRepository = customerRepository;
    private EmailSender emailSender = emailSender;

    public void register(string name, string email)
    {
        //TODO: Implement
    }
}