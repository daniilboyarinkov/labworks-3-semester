namespace LabWork6.Interfaces
{
    public interface IBankService
    {
        public string Name { get; }

        public double CalculateSalary(double baseSalary);
    }
}
