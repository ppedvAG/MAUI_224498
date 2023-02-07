using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKursApp.Bindings
{
    //Model-Klasse zur Verwendung im BindingContext
    //Das Interface INotifyPropertyChanged sorgt für ein neues Event, welches bei Aktivierung die GUI über eine Veränderung in diesem Objekt informiert
    internal class Person : INotifyPropertyChanged
    {
        //Eine Datenbindung kann nur an Properties durchgeführt werden (keine Felder)
        public string Name { get; set; }

        private int alter;
        public int Alter
        {
            get => alter;
            set
            {
                alter = value;
                //Das PropertyChanged-Event muss zu dem Zeitpunkt geworfen werden, zu dem die GUI über eine Veränderung informiert werden soll
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Alter)));
            }
        }

        //Durch das Interface geforderte Event
        public event PropertyChangedEventHandler PropertyChanged;

        //Properties vom Typ ObservableCollection informieren die GUI automatisch über Veränderungen (z.B. neuer Listeneintrag). Sie eignen sich besonders gut
        //für eine Bindung an ein ItemControl (z.B. Picker, ListView, CollectionView, ...)
       public ObservableCollection<DateTime> WichtigeTage { get; set; } = new ObservableCollection<DateTime>()
        {
            DateTime.Now,
            new DateTime(2003, 2, 12),
            new DateTime(2012, 5, 1),
            new DateTime(2021, 12, 30)
        };
    }
}
