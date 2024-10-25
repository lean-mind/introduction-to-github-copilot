namespace TeamAgreementLinter;

using System;

public class ProjectService
{
    private EmployeeRepository empRepo; 
    private RoleService rolSrv; 
    
    public ProjectService()
    {
        empRepo = new EmployeeRepository();
        rolSrv = new RoleService();
    }

    public void addEmployeeToProject(string projectName, Employee emp)
    {
        Project project = new Project(projectName);
        if (project.canAddMoreMembers())
        {
            project.addMember(emp);
            Console.WriteLine($"{emp.nombre} ha sido agregado al proyecto {project.projectName}");
        }
    }
}
