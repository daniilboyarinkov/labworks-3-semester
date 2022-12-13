using LabWork6.Components;

namespace LabWork6.ConcreteComponents
{
    public class Manager : Employee
    {
        public override string GetInfo()
            => $"{base.GetInfo()}\n" +
                $"Должность: Менеджер";
    }
}
