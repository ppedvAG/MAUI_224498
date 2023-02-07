namespace MauiKursApp;

public partial class Resources_Styles : ContentPage
{
	public Resources_Styles()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.Resources["Primary"] = Colors.LightGreen;
    }
}