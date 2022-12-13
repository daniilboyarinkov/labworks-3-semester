using LabWork6.Interfaces;
using LabWork6.Static;
using LabWork6.Stratagies;

namespace LabWork6.Components
{
    abstract public class Employee
    {
        public string Name { get; set; } = "Иванов Иван Иванович";
        public double BaseSalary { get; set; } = double.MinValue;
        public IBankService BankService { get; set; } = new Sberbank();

        public double CalculateSalary() => BankService.CalculateSalary(BaseSalary);
        public virtual string GetInfo() =>
            $"\n{Separators.EmployeeSeparator}\n" +
            $"{Name}\n" +
            $"Базовая зарплата:  {BaseSalary}\n" +
            $"Для перечисления зарплаты используется сервис {BankService.Name}\n" +
            $"Зарплата после удержания комиссии сервиса: {CalculateSalary()}\n";
    }
}
