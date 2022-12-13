using LabWork6.Components;
using LabWork6.ConcreteComponents;
using LabWork6.Decorators;
using LabWork6.Static;
using LabWork6.Stratagies;

Employee m1 = new Manager() { Name = "Петров Иван Васильевич", BaseSalary = 45000, BankService = new Gazprombank() };
m1 = new IntermediateEnglishSertificate(m1) { ExaminationTitile = "Экзамен по английскому", YearOfSertificate = 2007 };

Employee e1 = new Engineer() { Name = "Иванова Тамара Евгеньевна", BaseSalary = 60000, BankService = new Gazprombank() };

Employee s1 = new Scientist() { Name = "Сидоров Леонид Аркадьевич", BaseSalary = 50000, BankService = new Gazprombank() };
s1 = new AcademicDegree(s1) { DissertationTitile = "Влияние фазы луны на способность хомячков к полетам", Year=2015, ScienceArea="Бесполезные исследования, требующие инвестиций правительства" };

List<Employee> employees = new() { m1, s1, e1 };

employees.ForEach(e => Console.WriteLine(e.GetInfo()));

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(Separators.EmployeeSeparator);
Console.WriteLine($"{s1.Name}: добавлен сертификат о владении английским языком");
Console.WriteLine($"{e1.Name}: заменя сервиса");
Console.WriteLine(Separators.EmployeeSeparator);
Console.ResetColor();

s1 = new IntermediateEnglishSertificate(s1) { ExaminationTitile = "Новый экзамен по английскому", YearOfSertificate = 2022 };
e1.BankService = new Sberbank();

employees.ForEach(e => Console.WriteLine(e.GetInfo()));

