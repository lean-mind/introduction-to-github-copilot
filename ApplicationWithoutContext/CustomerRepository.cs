using Domain;

namespace ExternalServices;

public interface CustomerRepository
{
    public void save (Customer customer);
}