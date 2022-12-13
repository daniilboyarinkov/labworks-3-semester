using LabWork6.Components;
using LabWork6.ConcreteComponents;

namespace LabWork6.Decorators
{
    public abstract class EmployeeDecorator : Employee
    {
        protected readonly Employee Employee = new Engineer();

        protected EmployeeDecorator(Employee Employee) : base() 
            => this.Employee = Employee;
    }
}
