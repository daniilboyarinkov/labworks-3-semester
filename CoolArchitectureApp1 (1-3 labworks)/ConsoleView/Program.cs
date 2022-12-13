using ConsoleView;
using System;

namespace ConsoleView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {                
                App.PrintVariants();
                string variant = Console.ReadLine()?.Trim();
                if (variant == "1")
                {
                    Console.Clear();
                    App.PrintAllStudents();
                }
                else if (variant == "2")
                {
                    string name = App.Stdi("Введите имя студента: ");
                    string speciality = App.Stdi("Введите специальность студента: ");
                    string group = App.Stdi("Введите группу студента: ");

                    Console.Clear();
                    App.AddStudent(name, speciality, group);
                }
                else if (variant == "3")
                {
                    Console.Write("Введите Id студента в списке: ");

                    // id should be on that scope level. No refactor!
                    int id;

                    bool invalid = !int.TryParse(Console.ReadLine(), out id);
                    bool ok = true;

                    while (invalid)
                    {
                        if (invalid)
                            Console.Write("\nНекорректное значение.\nx (икс) - чтобы выйти\nПопробуйте снова: ");

                        string choice = Console.ReadLine() ?? string.Empty;
                        if (choice == "x")
                        {
                            ok = false;
                            break;
                        };
                        invalid = !int.TryParse(choice, out id);
                    }

                    if (ok)
                    {
                        Console.Clear();
                        App.DeleteStudent(id);
                    }
                    else Console.WriteLine("Что-то пошло не так...");
                }
                // skipping enters
                else if (variant == "") { }
                // skipping spaces
                else if (variant == " ") { }
                else
                {
                    Console.WriteLine("Извините, но такой команды нет.\n Введите существующую команду: ");
                }
            }
        }
    }
}
