namespace Domain;

public class Customer(string name, string email)
{
    public string Email { get; } = email;

    public string Name { get; } = name;
}