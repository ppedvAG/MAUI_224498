namespace MauiKursApp;

public partial class Xaml_Grundlagen : ContentPage
{
	public Xaml_Grundlagen()
	{
		InitializeComponent();

		
	}

    private async void Btn_KlickMich_Clicked(object sender, EventArgs e)
    {
		if(await DisplayAlert("FRAGE?", "Soll was gemacht werden?", "Ja", "Nein"))
			(sender as Button).Text = "Button wurde geklickt";
    }
}