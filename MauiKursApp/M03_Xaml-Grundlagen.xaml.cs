namespace MauiKursApp;

public partial class Xaml_Grundlagen : ContentPage
{
	public Xaml_Grundlagen()
	{
		InitializeComponent();

		
	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
        //Mittels eines DisplayAlerts können kleine (asynkrone) Aussagen und Abfragen an den Benutzer ausgegeben
        if (await DisplayAlert("FRAGE?", "Soll was gemacht werden?", "Ja", "Nein"))
            //Verändern der Text-Eigenschaft (angezeigter Text) des Buttons
            (sender as Button).Text = "Button wurde geklickt";
    }
}