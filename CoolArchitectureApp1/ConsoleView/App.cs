using Business_Logic;

namespace ConsoleView
{
    public static class App
    {
        public static readonly Logic BL = new();

        public static void InitApp()
        {
            BL.InitStudents();
        }

        public static void PrintVariants()
        {
            Console.WriteLine("1 - посмотреть список студентов\n2 - добавить студента\n3 - удалить студента\n");
        }

        public static string Stdi(string text)
        {
            string? step;

            Console.Write(text);
            step = Console.ReadLine();
            if (!string.IsNullOrEmpty(step))
                return step;
            return string.Empty;
        }

        public static void PrintAllStudents()
        {
            int index = 0;
            Console.WriteLine();
            BL.Students.ForEach(st => Console.WriteLine(
                $"id: {index++}\t Имя: {st.Name}\t Специальность: {st.Speciality}\t Группа: {st.Group}\n")
            );
        }
        public static void AddStudent(string name, string speciality, string group)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(speciality) || string.IsNullOrEmpty(group))
                ok = false;

            if (ok)
            {
                BL.AddStudent(name, speciality, group);
                Console.WriteLine($"\nСтудент {name} {speciality} {group} успешно добавлен!\n");
            }
            else
            {
                Console.WriteLine("Одно или несколько значений были введены неверно...");
            }
        }
        public static void DeleteStudent(int id)
        {
            bool impossible = id < 0 || id >= BL.Students.Count;

            if (impossible) {
                Console.WriteLine("Введено невозможное значение...");
            }
            else
            {
                BL.DeleteStudent(id);
                Console.WriteLine($"\nСтудент с индексом {id} успешно удален!\n");
            }
        }
    }
}
