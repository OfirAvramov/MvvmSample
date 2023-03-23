using BindingToObject.Models;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
      


        public ObservableCollection<Student> Students { get; set; }

        public ICommand LoadDataCommand { get; private set; } 

        public ICommand ClearDataCommand { get; private set; }

        public ICommand RefreshCommand { get; private set; }

        string name;
        public string CurrentName { get { return name; } set { if(name!= value) { name = value; OnPropertyChanged(); } } }

        DateTime date;
        public DateTime CurrentDate { get { return date; } set { if (date != value) { date = value; OnPropertyChanged(); } } }

        bool isRefreshing;
        public bool IsRefreshing { get { return isRefreshing; } set { if (isRefreshing != value) { isRefreshing = value; OnPropertyChanged(); } } }

        public ICommand AddStuCommand { get; private set; }
        public MainPageViewModel()
        {
            Students = new ObservableCollection<Student>(); 
            LoadDataCommand=new Command(LoadData);
            ClearDataCommand = new Command(() => Students.Clear());
            RefreshCommand = new Command(LoadData);
            AddStuCommand = new Command(()=>Students.Add(new Student() { BirthDate=CurrentDate, Image=$"{CurrentName}.jpg", Name=CurrentName}));
            
        }

        public void LoadData()
        {
            Students.Clear();
           Students.Add(new Student() { BirthDate = DateTime.Now, Name = "ג'ופיר", Image = "jofir.jpg" });
            Students.Add(new Student() { BirthDate = DateTime.Now, Name = "ג'ופיר", Image = "jofir.jpg" });
            IsRefreshing = false;
            
        }

    }
}
