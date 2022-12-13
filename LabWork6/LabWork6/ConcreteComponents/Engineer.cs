using LabWork6.Components;

namespace LabWork6.ConcreteComponents
{
    public class Engineer : Employee
    {
        public override string GetInfo() 
            =>  $"{base.GetInfo()}\n" +
                $"Должность: Инженер";
    }
}
