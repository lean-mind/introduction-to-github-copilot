namespace Application;
using Domain;

public interface CustomerRepository
{
    public void save (Customer customer);
}