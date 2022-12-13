using LabWork6.Components;
using LabWork6.Static;

namespace LabWork6.Decorators
{
    public class IntermediateEnglishSertificate : EmployeeDecorator
    {
        public string ExaminationTitile { get; set; } = string.Empty;
        public int YearOfSertificate { get; set; }

        public IntermediateEnglishSertificate(Employee Employee) : base(Employee)
        { }

        public override string GetInfo()
            =>
            $"{Employee.GetInfo()}\n" +
            $"{Separators.InfoSeparator}\n" +
            $"Экзамен: {ExaminationTitile}\n" + 
            $"Год получения сертификата: {YearOfSertificate}\n";
    }
}
