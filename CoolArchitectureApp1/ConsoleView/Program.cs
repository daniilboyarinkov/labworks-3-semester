using ConsoleView;

App.InitApp();
App.PrintVariants();

while (true)
{
    string? variant = Console.ReadLine()?.Trim();
    if (variant == "1")
    {
        App.PrintAllStudents();
    }
    else if (variant == "2")
    {
        string name = App.Stdi("Введите имя студента: ");
        string speciality = App.Stdi("Введите специальность студента: ");
        string group = App.Stdi("Введите группу студента: ");

        App.AddStudent(name, speciality, group);
    }
    else if (variant == "3")
    {
        Console.Write("Введите индекс студента в списке: ");

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

        if (ok) App.DeleteStudent(id);
        else Console.WriteLine("Что-то пошло не так...");
    }
    // skipping enters
    else if (variant == "") { }
    // skipping spaces
    else if (variant == " ") { }
    else
    {
        Console.WriteLine("Извините, но такой команды нет.\n Введите существующую команду: ");
        App.PrintVariants();
    }
}
