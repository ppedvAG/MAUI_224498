using MauiKursApp.MVVM.Model;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiKursApp.MVVM.ViewModel
{
    //Im ViewModel-Teil eines MVVM-Programms werden Klassen definiert, welche als Verbindungsstück zwischen den Views und den Modelklassen fungieren.
    //Diese Klassen sind die einzigen Programmteile, welche Referenzen auf Model-Klassen beinhalten. Sie selbst sind jeweils einem View zugrordnet,
    //mit welchem sie (nur) über den BindingContext des jeweiligen Views verbunden sind.
    //INotifyPropertyChanged informiert die GUI über Veränderungen in den Daten
    public class BeispielViewModel : INotifyPropertyChanged
    {
        private string neuerHersteller = String.Empty;
        private int neueMaxGeschwindigkeit = 0;
        private DateTime neuesBaujahr = new DateTime();

        public string NeuerHersteller { get => neuerHersteller; set { neuerHersteller = value; HinzufügenCmd.ChangeCanExecute(); } }
        public int NeueMaxGeschwindigkeit { get => neueMaxGeschwindigkeit; set { neueMaxGeschwindigkeit = value; HinzufügenCmd.ChangeCanExecute(); } }
        public DateTime NeuesBaujahr { get => neuesBaujahr; set { neuesBaujahr = value; HinzufügenCmd.ChangeCanExecute(); } }


        //Property zur Repräsentation der Anzahl der geladenen Personen (verlinkt an die Model-Klasse)
        public ObservableCollection<Model.PKW> PkwListe
        {
            get { return Model.PKW.PkwListe; }
            set { Model.PKW.PkwListe = value; }
        }

        //Command-Properties
        public Command HinzufügenCmd { get; set; }
        public Command LöschenCmd { get; set; }
        public Command UpdateSelecedPKW { get; set; }


        //Konstruktor
        public BeispielViewModel()
        {
            HinzufügenCmd = new Command
                (
                    //Execute-Methode des Commands (Definiert, was das Command bei Ausführung tut)
                    () =>
                    {
                        Model.PKW neuerPKW = new Model.PKW() { Hersteller = NeuerHersteller, MaxGeschwindigkeit = NeueMaxGeschwindigkeit, Herstellungjahr = NeuesBaujahr };

                        PkwListe.Add(neuerPKW);

                        NeuerHersteller = string.Empty;
                        NeueMaxGeschwindigkeit = 0;
                        NeuesBaujahr = new DateTime();

                        InformView(nameof(NeuerHersteller));
                        InformView(nameof(NeueMaxGeschwindigkeit));
                        InformView(nameof(NeuesBaujahr));
                    },
                    //CanExecute-Methode des Commands (Definiert, wann das Command ausgeführt werden darf)
                    () =>
                    {
                        return !NeuerHersteller.Equals(string.Empty) && NeueMaxGeschwindigkeit > 0 && NeuesBaujahr.Year > 1950;
                    }
                );

            LöschenCmd = new Command(ExecuteLöschenCmd, CanExecuteLöschenCmd);

            UpdateSelecedPKW = new Command(() => LöschenCmd.ChangeCanExecute());
        }

        private void ExecuteLöschenCmd(object listView)
        {
            PkwListe.Remove((listView as ListView).SelectedItem as PKW);
            (listView as ListView).ClearValue(ListView.SelectedItemProperty);
            LöschenCmd.ChangeCanExecute();
        }
        private bool CanExecuteLöschenCmd(object listView) => (listView as ListView)?.SelectedItem is Model.PKW;

        #region INotifyPropertyChanged
        //Aufruf des PropertyChanged-Events zur Benachrichtigung der GUI über Veränderungen
        private void InformView(string prop) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

    }
}
