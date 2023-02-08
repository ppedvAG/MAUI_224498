using MauiKursApp.MVVM.Model;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKursApp.MVVM.ViewModel
{
    public class BeispielViewModel
    {
        private string neuerHersteller = String.Empty;
        private int neueMaxGeschwindigkeit;
        private DateTime neuesHerstellungsdatum;

        public string NeuerHersteller { get => neuerHersteller; set { neuerHersteller = value; HinzufügenCmd.ChangeCanExecute(); } }
        public int NeueMaxGeschwindigkeit { get => neueMaxGeschwindigkeit; 
            set 
            { 
                neueMaxGeschwindigkeit = value; 
                HinzufügenCmd.ChangeCanExecute(); 
            } }
        public DateTime NeuesHerstellungsdatum { get => neuesHerstellungsdatum; set { neuesHerstellungsdatum = value; HinzufügenCmd.ChangeCanExecute(); } }

        public ObservableCollection<Model.PKW> PKWListe
        {
            get { return Model.PKW.PKWListe; }
            set { Model.PKW.PKWListe = value; }
        }

        public Command HinzufügenCmd { get; set; }
        public Command LöschenCmd { get; set; }


        public BeispielViewModel()
        {
            HinzufügenCmd = new Command
                (
                    () =>
                    {
                        Model.PKW neuerPKW = new PKW();

                        neuerPKW.Hersteller = NeuerHersteller;
                        neuerPKW.MaxGeschwindigkeit = NeueMaxGeschwindigkeit;
                        neuerPKW.Herstellungsdatum = NeuesHerstellungsdatum;

                        PKWListe.Add(neuerPKW);
                    },
                    ()=>
                    {
                        return !NeuerHersteller.Equals(string.Empty) && NeueMaxGeschwindigkeit > 0 && NeuesHerstellungsdatum.Year < DateTime.Now.Year;
                    }
            
                );

            LöschenCmd = new Command
                (
                    listView =>
                    {
                        PKWListe.Remove((listView as ListView).SelectedItem as Model.PKW);
                    }
                );

            HinzufügenCmd.ChangeCanExecute();
        }
    }
}
