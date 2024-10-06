using ExternalServices;

namespace UseCaseWithoutContext;

public class RegisterCustomerWithoutContext(CustomerRepository customerRepository, EmailSender emailSender)
{
    private CustomerRepository customerRepository = customerRepository;
    private EmailSender emailSender = emailSender;

    public void register(string name, string email)
    {
        //TODO: Implement
    }
}