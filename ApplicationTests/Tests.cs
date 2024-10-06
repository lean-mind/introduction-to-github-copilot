using Application;
using Domain;
using NSubstitute;


namespace ApplicationTests;

public class Tests
{
    string nameCustomer;
    string emailCustomer;
    CustomerRepository customerRepository;
    EmailSender emailSender;

    public Tests()
    {
        nameCustomer = "Mario Pinto";
        emailCustomer = "mario@hotmail.com";
        customerRepository = Substitute.For<CustomerRepository>();
        emailSender = Substitute.For<EmailSender>();
    }


    [Fact]
    public void happy_path()
    {
        var registerCustomer = new RegisterCustomer(customerRepository, emailSender);
        
        registerCustomer.register(nameCustomer, emailCustomer);
        
        customerRepository.Received().save(new Customer(nameCustomer, emailCustomer));
        emailSender.Received().sendConfirmationEmailTo(new Customer(nameCustomer, emailCustomer));
    }
}