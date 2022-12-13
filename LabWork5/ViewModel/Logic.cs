using GalaSoft.MvvmLight.Command;
using Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;

namespace ViewModel
{
    public class Logic : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string prop = " ") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public ObservableCollection<Speciality> Specialities { get; set; } = new();
        public ObservableCollection<Student> Students { get; set; } = new() {
            new Student() { Name = "Àíäðåé", Group = "ÊÈ21-22Á", Speciality = "ÏÈ"},
            new Student() { Name = "Àëåêñåé", Group = "ÊÈ21-12Á", Speciality = "ÏÈ"},
            new Student() { Name = "Àðòóð", Group = "ÊÈ21-21Á", Speciality = "ÈÑÈÒ"},
            new Student() { Name = "Àáäóðîçèê", Group = "ÃÈ21-20Á", Speciality = "ÔÈ"},
            new Student() { Name = "Àðòåì", Group = "ÓÁ21-02Á", Speciality = "ÈÑÈÒ"}
        };

        public Logic() => UpdateHistogram();

        public Student? NewStudent { get; set; } = new();
        public Student? SelectedStudent { get; set; }

        private RelayCommand? _deleteStudent;
        private RelayCommand? _addStudent;

        public RelayCommand DeleteStudent => _deleteStudent
                    ??= new RelayCommand(() =>
                    {
                        if (SelectedStudent is null) 
                            MessageBox.Show("Âûáåðèòå õîòü ÷òî-íèáóäü. íó ñåðüåçíî...", "ÒÀÊ ÝÒÎ ×ÒÎ ÒÀÊÎÅ ÒÓÒ");
                        else Students.Remove(SelectedStudent);
                        UpdateHistogram();
                    });

        public RelayCommand AddStudent => _addStudent
            ??= new RelayCommand(
                () =>
                {
                    if (NewStudent is null)
                    {
                        MessageBox.Show("Òû ìíå êàæåòñÿ ÷òî-òî ïîïóòàë", "ÒÀÊ ÝÒÎ ×ÒÎ ÒÀÊÎÅ ÒÓÒ");
                        return;
                    }
                    if (string.IsNullOrEmpty(NewStudent.Name) || string.IsNullOrEmpty(NewStudent.Speciality) | string.IsNullOrEmpty(NewStudent.Group))
                        MessageBox.Show("Òû ìíå êàæåòñÿ ÷òî-òî ïîïóòàë", "ÒÀÊ ÝÒÎ ×ÒÎ ÒÀÊÎÅ ÒÓÒ");
                    else Students.Add(new Student() { Name = NewStudent.Name, Speciality = NewStudent.Speciality, Group = NewStudent.Group });
                    UpdateHistogram();
                });

        public void UpdateHistogram()
        {
            Specialities.Clear();
            Students
                .GroupBy(x => x.Speciality)
                .Select(x => new { Speciality = x.Key, Count = x.Count() })
                .ToList()
                .ForEach(d => Specialities.Add(
                    new Speciality() { Name = d.Speciality, Count = d.Count, Percent = d.Count * 100 / Students.Count }
                 ));
        }
    }
}
