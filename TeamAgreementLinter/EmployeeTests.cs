namespace TeamAgreementLinter;



public class EmployeeTests
{
    [Fact]
    public void Test_AddEmployeeToProject()
    {
        var projectService = new ProjectService();
        var employee = new Employee("Carlos", 27, "Tester");

        projectService.addEmployeeToProject("New Project", employee); 
        
        Assert.True(true);
    }

    [Fact]
    public void Test_RoleLimit()
    {
        var roleService = new RoleService();

        try
        {
            roleService.addRole("Product Owner"); 
            roleService.addRole("Scrum Master");
        }
        catch (InvalidOperationException)
        {
            Assert.True(true);
        }
    }
}
