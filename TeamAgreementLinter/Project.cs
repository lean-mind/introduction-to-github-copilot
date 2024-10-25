namespace TeamAgreementLinter;

using System.Collections.Generic;

public class Project
{
    public string projectName; 
    public List<Employee> teamMembers; 
    private bool _isActive; 

    public Project(string name)
    {
        projectName = name;
        teamMembers = new List<Employee>();
        _isActive = true;
    }

    public void addMember(Employee emp) 
    {
        teamMembers.Add(emp);
    }

    public bool canAddMoreMembers() 
    {
        return _isActive && teamMembers.Count < 10;
    }
}
