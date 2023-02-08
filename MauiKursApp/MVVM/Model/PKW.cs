using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKursApp.MVVM.Model
{
    public class PKW
    {
        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public DateTime Herstellungsdatum { get; set; }


        public static ObservableCollection<PKW> PKWListe { get; set; } = new ObservableCollection<PKW>()
        {
            new PKW{Hersteller="Audi", MaxGeschwindigkeit=200, Herstellungsdatum=new DateTime(2003, 4, 12)}
        };

    }
}
