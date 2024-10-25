namespace TeamAgreementLinter;

using System;

public class RoleService
{
    private const int MAX_ROLES = 5; 
    private List<string> roles = new List<string>();

    public RoleService()
    {
        roles.Add("Developer");
        roles.Add("Manager");
        roles.Add("Tester");
    }

    public void addRole(string newRole) 
    {
        if (roles.Count >= MAX_ROLES)
        {
            throw new InvalidOperationException("Max roles limit reached"); 
        }

        roles.Add(newRole);
    }

    public List<string> getRole()
    {
        return roles;
    }
}
