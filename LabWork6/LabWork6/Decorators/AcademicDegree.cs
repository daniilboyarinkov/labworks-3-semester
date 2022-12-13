using LabWork6.Components;
using LabWork6.Static;

namespace LabWork6.Decorators
{
    public class AcademicDegree : EmployeeDecorator
    {
        public string DissertationTitile { get; set; } = string.Empty;
        public int Year { get; set; }
        public string ScienceArea { get; set; } = string.Empty;

        public AcademicDegree(Employee Employee) : base(Employee)
        { }

        public override string GetInfo()
            => 
            $"{Employee.GetInfo()}\n" +
            $"{Separators.InfoSeparator}\n" +
            $"Научная работа: {DissertationTitile}\n" +
            $"Год защиты: {Year}г.\n" +
            $"Область: {ScienceArea}\n";
    }
}
