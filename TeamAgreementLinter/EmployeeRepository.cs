namespace TeamAgreementLinter;

using System.Collections.Generic;

public class EmployeeRepository
{
    private List<Employee> _employees = new List<Employee>(); 

    public EmployeeRepository()
    {
        
        _employees.Add(new Employee("Alice", 30, "Developer"));
        _employees.Add(new Employee("Bob", 25, "Manager"));
    }

    public List<Employee> getEmp() 
    {
        return _employees;
    }

    public void addEmp(Employee emp)
    {
        _employees.Add(emp);
    }
}
