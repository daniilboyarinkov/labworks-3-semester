using LabWork6.Interfaces;

namespace LabWork6.Stratagies
{
    public class Gazprombank : IBankService
    {
        public string Name => "Газпромбанк";

        // 1.5% комиссии
        public double CalculateSalary(double baseSalary) => baseSalary - 0.015 * baseSalary;
    }
}
