using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace xaml_test
{
    class Employee : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged( [CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        private string name;
        public string Name
        {
            set { name = value; RaisePropertyChanged();}
            get { return name; }
        }

        private string title;
        public string Title
        {
            set
            {
                title = value;
                RaisePropertyChanged();
            }
            get { return title; }
        }

        private bool wasReelcted;
        public bool WasReelcted
        {
            set
            {
                wasReelcted = value;
                RaisePropertyChanged();
            }
            get { return wasReelcted; }
        }

        public enum Party
        {
            Indepentent, Federalist, DemocratRepublican
        }

        private Party affiliation;
        public Party Affiliation
        {
            get { return affiliation; }
            set { affiliation = value; RaisePropertyChanged(); }
        }

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();

            employees.Add(new Employee()
            {Name = "Ali", Title = "Minister", WasReelcted = false, Affiliation = Party.DemocratRepublican});

            employees.Add(new Employee()
            { Name = "Mahinda", Title = "PriMinister", WasReelcted = true, Affiliation = Party.Federalist});

            employees.Add(new Employee()
            { Name = "Sirisena", Title = "Gobbaya", WasReelcted = false, Affiliation = Party.Indepentent });

            employees.Add(new Employee()
            { Name = "Ranil", Title = "Gobbaya II", WasReelcted = true, Affiliation = Party.Federalist });

            return employees;
        }

    }
}
