using System;
using System.Collections.Generic;
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

    }
}
