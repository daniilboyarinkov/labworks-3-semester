using Business_Logic;
using Model;
using Ninject;
using System;

namespace ConsoleView
{
    public static class App
    {
        private static readonly IKernel ninjectKernel = new StandardKernel(new SimpleConfigModule());
        private static readonly Logic BL = ninjectKernel.Get<Logic>();

        public static void PrintVariants()
        {
            Console.WriteLine($"{new string('-', 42)}\n{new string('-', 4)}" +
                $"\t1 - посмотреть список студентов\n{new string('-', 4)}" +
                $"\t2 - добавить студента\n{new string('-', 4)}" +
                $"\t3 - удалить студента\n" +
                $"{new string('-', 42)}\n");
        }

        public static string Stdi(string text)
        {
            string step;

            Console.Write(text);
            step = Console.ReadLine();
            if (!string.IsNullOrEmpty(step))
                return step;
            return string.Empty;
        }

        public static void PrintAllStudents()
        {
            var students = BL.GetAll();
            foreach (Student st in students)
            {
                Console.WriteLine(
                $"id: {st.Id}\t Имя: {st.Name}\t Специальность: {st.Speciality}\t Группа: {st.Group}\n");
            }
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
            // bool impossible = id < 0 || id >= BL.GetAll().Count();
            bool impossible = id < 0;

            if (impossible)
            {
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