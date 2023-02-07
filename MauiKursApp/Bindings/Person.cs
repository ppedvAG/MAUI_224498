using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKursApp.Bindings
{
    internal class Person : INotifyPropertyChanged
    {
        private int alter;

        public string Name { get; set; }
        public int Alter 
        { 
            get => alter;
            set
            {
                alter = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<DateTime> WichtigeTage { get; set; } = new ObservableCollection<DateTime>()
        {
            DateTime.Now,
            new DateTime(2003, 2, 12),
            new DateTime(2012, 5, 1),
            new DateTime(2021, 12, 30)
        };
    }
}
