using LabWork6.Interfaces;

namespace LabWork6.Stratagies
{
    public class Sberbank : IBankService
    {
        public string Name => "Сбербанк";

        // 1% комиссии
        public double CalculateSalary(double baseSalary) => baseSalary - 0.01 * baseSalary;
    }
}
