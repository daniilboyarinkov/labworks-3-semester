using System.ComponentModel;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace Model
{
    public class Student : INotifyPropertyChanged
    {
        private string? name;
        private string? speciality;
        private string? group;

        public string? Name 
        { 
            get => name; 
            set 
            { 
                name = value; 
                NotifyPropertyChanged("Name"); 
            } 
        }
        public string? Speciality 
        { 
            get => speciality; 
            set  
            { 
                speciality = value; 
                NotifyPropertyChanged("Speciality"); 
            } 
        }
        public string? Group 
        { 
            get => group; 
            set 
            { 
                group = value; 
                NotifyPropertyChanged("Group"); 
            } 
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] string prop = " ") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }

}
