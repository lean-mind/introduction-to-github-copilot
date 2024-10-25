namespace TeamAgreementLinter;

using System;

public class Employee
{
    public string nombre;
    private int _edad; 
    private bool activo; 
    private string rol; 
    
    public Employee(string name, int age, string role)
    {
        if (age < 18) 
        {
            throw new ArgumentException("Age must be at least 18");
        }
        
        nombre = name;
        _edad = age;
        activo = true;
        rol = role;
    }

    public void asignarRol(string nuevoRol) 
    {
        rol = nuevoRol;
    }
}
